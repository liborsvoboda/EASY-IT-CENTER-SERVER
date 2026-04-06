using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Net.Http;
using System.Net.Http.Headers;


namespace EasyITCenter.Controllers {


    //[Authorize]
    [ApiController]
    [Route("PlaygroundStudioService/PlayGroundStudio")]
    public class PlaygroundStudioService : Controller {

        private RepoMapper mapper;
        private readonly ILogger logger;
        private string repoPath;


        public PlaygroundStudioService(ILogger<PlaygroundStudioService> logger) {
            repoPath = System.IO.Path.Combine(SrvRuntime.SrvPrivatePath, "Databases", "Playground");
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);
            mapper = new RepoMapper(System.IO.Path.Combine(SrvRuntime.SrvPrivatePath, "Databases", "Playground", "PlayGround.db"));
            this.logger = logger;
        }


        [HttpGet("/PlaygroundStudioService/PlayGroundStudio/output/{id}/{milestone}")]
        public IActionResult Output(string id, string milestone) {
            var entry = mapper.GetEntry(id);
            if (entry != null)
            {
                int milestoneInt;
                if (!int.TryParse(milestone, out milestoneInt))
                    milestoneInt = entry.LastMilestone;
                else
                {
                    if (milestoneInt >= 1 && milestoneInt <= entry.LastMilestone)
                    {
                        // ok
                    }
                    else
                        milestoneInt = entry.LastMilestone;
                }

                var path = System.IO.Path.Combine(repoPath, entry.Key);

                if (!System.IO.Directory.Exists(path))
                    return NotFound();

                string filename;
                filename = System.IO.Path.Combine(path, "output_" + milestoneInt + ".html");
                if (System.IO.File.Exists(filename))
                {
                    return File(System.IO.File.OpenRead(filename), "text/html");
                }
                else
                    return NotFound();

            }
            else
                return NotFound();
        }


        [HttpPost("/PlaygroundStudioService/PlayGroundStudio/newFile")]
        public IActionResult NewFile([FromBody] string description) {
            RepoMapper.Entry entry;
            entry = new RepoMapper.Entry()
            {
                Key = GenerateUniqueNewName(),
                Description = description,
                LastMilestone = 1,
                LastUpdated = DateTime.Now,
                IsNew = true
            };

            mapper.InsertEntry(entry);
            mapper.InsertMilestone(new RepoMapper.EntryMilestone() { Created = entry.LastUpdated, Comments = "", Nr = entry.LastMilestone, EntryKey = entry.Key });

            logger.LogInformation("Creating new entry" + entry.Key);

            return Json(new HandlerResult()
            {
                result = new
                {
                    name = entry.Key,
                    milestone = entry.LastMilestone,
                    html = GetDefaultHTML(),
                    css = GetDefaultCSS(),
                    typescript = GetDefaultTypescript()
                },
                success = true
            });
        }


        [HttpPost("/PlaygroundStudioService/PlayGroundStudio/loadFile")]
        public IActionResult LoadFile([FromBody] LoadFileRequest loadFileRequest) {
            var entry = mapper.GetEntry(loadFileRequest.file);
            if (entry == null)
                return Json(new HandlerResult() { success = false, message = "File does not exists" });

            var path = System.IO.Path.Combine(repoPath, loadFileRequest.file);

            if (loadFileRequest.milestone == "-1")
            {
                loadFileRequest.milestone = entry.LastMilestone + ""; 
            }
            else
            {
                int ms;
                if (!int.TryParse(loadFileRequest.milestone, out ms))
                    return Json(new HandlerResult() { success = false, message = "Invalid milestone" });
                if (ms > entry.LastMilestone)
                    return Json(new HandlerResult() { success = false, message = "Invalid milestone" });
            }

            string html;
            string css;
            string typescript;

            string filename;
            filename = System.IO.Path.Combine(path, "html_" + loadFileRequest.milestone + ".html");
            if (System.IO.File.Exists(filename))
                html = System.IO.File.ReadAllText(filename);
            else
            {
                html = GetDefaultHTML();
                //return Json(new HandlerResult() { Success = false, Message = "Files not available" });
            }


            filename = System.IO.Path.Combine(path, "css_" + loadFileRequest.milestone + ".css");
            if (System.IO.File.Exists(filename))
                css = System.IO.File.ReadAllText(filename);
            else
            {
                css = GetDefaultCSS();
                //return Json(new HandlerResult() { Success = false, Message = "Files not available" });
            }
            filename = System.IO.Path.Combine(path, "ts_" + loadFileRequest.milestone + ".ts");
            if (System.IO.File.Exists(filename))
                typescript = System.IO.File.ReadAllText(filename);
            else
            {
                typescript = GetDefaultTypescript();
                //return Json(new HandlerResult() { Success = false, Message = "Files not available" });
            }
            logger.LogInformation("Loading entry " + entry.Key);


            return Json(new HandlerResult()
            {
                result = new
                {
                    name = loadFileRequest.file,
                    milestone = loadFileRequest.milestone,
                    description = entry.Description,
                    html = html,
                    css = css,
                    typescript = typescript
                },
                success = true
            });
        }



        [HttpPost("/PlaygroundStudioService/PlayGroundStudio/saveFile")]
        [Consumes("application/json")]
        public string SaveFile([FromBody] CreateSaveRequest createSaveRequest) {
            if (string.IsNullOrEmpty(createSaveRequest.name) || createSaveRequest.name.Contains(".."))
                //return Json(new HandlerResult() { success = false });
                return JsonSerializer.Serialize(new HandlerResult() { success = false });

            var entry = mapper.GetEntry(createSaveRequest.name);
            if (entry == null)
                return JsonSerializer.Serialize(new HandlerResult() { success = false });

            if (createSaveRequest.milestone < entry.LastMilestone) {
                return JsonSerializer.Serialize(new HandlerResult() { success = false, message = "Can't save an older milestone. Last milestone is " + entry.LastMilestone });
            }

            Save(entry, createSaveRequest.html, createSaveRequest.css, createSaveRequest.typescript, createSaveRequest.output);

            logger.LogInformation("Saving entry " + entry.Key + ", last milestone : " + entry.LastMilestone);

            return JsonSerializer.Serialize(new HandlerResult() { success = true });
        }


        [HttpGet("/PlaygroundStudioService/PlayGroundStudio/listFiles")]
        public IActionResult ListFiles() {
            var entries = mapper.GetEntries().Where(e => !e.IsNew).ToList();

            try { var names = System.IO.Directory.GetDirectories(repoPath); } catch { }
            return Json(new HandlerResult()
            {
                result = entries.OrderByDescending(e => e.LastUpdated)
                                .Select(e => new { name = e.Key, milestone = e.LastMilestone, lastUpdated = e.LastUpdated.ToString("yyyy-MM-dd"), description = e.Description })
                                .ToArray(),
                success = true
            });
        }


        [HttpPost("/PlaygroundStudioService/PlayGroundStudio/createMilestone")]
        public IActionResult CreateMileStone([FromBody] CreateSaveRequest createSaveRequest) {

            var entry = mapper.GetEntry(createSaveRequest.name);
            if (entry == null)
                return Json(new HandlerResult() { success = false });
            entry.LastMilestone++;

            Save(entry, createSaveRequest.html, createSaveRequest.css, createSaveRequest.typescript, createSaveRequest.output);
            logger.LogInformation("Creating new milestone " + entry.LastMilestone + " for " + entry.Key);
            mapper.InsertMilestone(new RepoMapper.EntryMilestone()
            {
                EntryKey = createSaveRequest.name,
                Nr = entry.LastMilestone,
                Created = DateTime.Today,
                Comments = createSaveRequest.comments
            });
            return Json(new HandlerResult()
            {
                result = new
                {
                    name = createSaveRequest.name,
                    description = entry.Description,
                    milestone = entry.LastMilestone
                },
                success = true
            });
        }


        [HttpPost("/PlaygroundStudioService/PlayGroundStudio/deleteMilestone")]
        public IActionResult DeleteMilestone([FromBody] string name) {
            var entry = mapper.GetEntry(name);
            if (entry == null)
                return Json(new HandlerResult() { success = false });

            if (entry.LastMilestone == 1)
            {
                mapper.DeleteEntry(entry);
                return Json(new HandlerResult() { success = true, result = true });
            }
            else
            {
                int milestone = entry.LastMilestone;
                entry.LastMilestone--;
                mapper.UpdateEntry(entry);

                var ms = mapper.GetMilestone(name, milestone - 1);
                if (ms != null)
                    mapper.DeleteMilestone(ms);

                return Json(new HandlerResult() { success = true, result = false });
            }
        }


        [HttpPost("/PlaygroundStudioService/PlayGroundStudio/updateDescription")]
        public IActionResult UpdateDescription([FromBody] UpdateDescriptionRequest updateDescription) {
            var entry = mapper.GetEntry(updateDescription.name);
            if (entry == null)
                return Json(new HandlerResult() { success = false });

            entry.Description = updateDescription.description;
            mapper.UpdateEntry(entry);

            return Json(new HandlerResult() { success = true });
        }

        private void Save(RepoMapper.Entry entry, string html, string css, string typescript, string output) {
            var path = System.IO.Path.Combine(repoPath, entry.Key);
            if (!System.IO.Directory.Exists(path))
                System.IO.Directory.CreateDirectory(path);


            string filename;

            filename = System.IO.Path.Combine(path, "html_" + entry.LastMilestone + ".html");
            System.IO.File.WriteAllText(filename, html);

            filename = System.IO.Path.Combine(path, "css_" + entry.LastMilestone + ".css");
            System.IO.File.WriteAllText(filename, css);

            filename = System.IO.Path.Combine(path, "ts_" + entry.LastMilestone + ".ts");
            System.IO.File.WriteAllText(filename, typescript);

            filename = System.IO.Path.Combine(path, "output_" + entry.LastMilestone + ".html");
            System.IO.File.WriteAllText(filename, output);

            entry.IsNew = false;
            entry.LastUpdated = DateTime.Now;
            mapper.UpdateEntry(entry);
        }


        private string GenerateNewName() {
            char[] chars = "bcdfghjklmnpqrstvwxz".ToCharArray();
            char[] vowels = "aeiou".ToCharArray();

            Random rnd = new Random();
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                    str.Append(chars[rnd.Next(chars.Length)]);
                else
                    str.Append(vowels[rnd.Next(vowels.Length)]);
            }
            return str.ToString();
        }


        private string GenerateUniqueNewName() {
            int errCount = 0;
            string name = GenerateNewName();
            while (System.IO.Directory.Exists(System.IO.Path.Combine(repoPath, name)) && errCount++ < 10)
                name = GenerateNewName();
            return name;
        }

        private int GetLastMilestone(string name) {
            var path = System.IO.Path.Combine(repoPath, name);
            if (!System.IO.Directory.Exists(path))
                return -1;
            else
            {
                var milestones = System.IO.Directory.GetFiles(path).Where(f => System.IO.Path.GetFileName(f).StartsWith("ts_")).Select(f => int.Parse(System.IO.Path.GetFileNameWithoutExtension(f).Split('_')[1])).ToArray();
                if (milestones.Length > 0)
                    return milestones.Max();
                else
                    return 1;
            }
        }

        //TODO insert TEMPLATES
        private string GetDefaultHTML() {
                return
@"<html>
<head>
    <title>Typescript Editor - Hello</title>
    <!--%CSS%-->
</head>
<body>
    <h1>New typescript snippet</h1>
    <!--%Javascript%-->
</body>
    
</html>";
        }

        //TODO insert TEMPLATES
        private string GetDefaultCSS() {
            string path = System.IO.Path.Combine(repoPath, "default.css");
                return
@"body {

}";
        }

        //TODO insert TEMPLATES
        private string GetDefaultTypescript() {
                return
@"class Hello {

}";
        }

        public class HandlerResult {
            public bool success { get; set; }
            public object result { get; set; }
            public string message { get; set; }
        }


        public class CreateSaveRequest
        {
            public string name { get; set; }
            public int? milestone { get; set; } = null;
            public string html { get; set; }
            public string css { get; set; }
            public string typescript { get; set; }
            public string output { get; set; }

            public string comments { get; set; } = null;
        }

        public class LoadFileRequest
        {
            public string file { get; set; } 
            public string milestone { get; set; }
        }

        public class UpdateDescriptionRequest
        {
            public string name { get; set; } 
            public string description { get; set; }
        }
    }
}
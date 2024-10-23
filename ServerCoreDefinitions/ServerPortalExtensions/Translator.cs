using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Translate;
using Google.Apis.Translate.v3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApisTranslateWrapper
{

    /// <summary>
    /// Google Translator Service
    /// </summary>
    [ComVisible(true), ClassInterface(ClassInterfaceType.AutoDual)]
    [Obsolete]
    public class Translator
    {
        TranslateService _translateService;
        string _projectId;

        public Translator(HttpContext httpContext)
        {
            var keyJsonFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),@"key.json");

            try
            {
                var credential = GoogleCredential.FromFile(keyJsonFilePath);
                
                if (!(credential.UnderlyingCredential is ServiceAccountCredential))
                    throw new Exception("key.json should define a ServiceAccountCredential");

                _projectId = ((ServiceAccountCredential)credential.UnderlyingCredential).ProjectId;

                if (credential.IsCreateScopedRequired)
                    credential = credential.CreateScoped(TranslateService.Scope.CloudTranslation);

                _translateService = new TranslateService(new BaseClientService.Initializer
                {
                    ApplicationName = nameof(GoogleApisTranslateWrapper),
                    HttpClientInitializer = credential
                });
            }
            catch (Exception ex)
            {

            }
        }


        public string Translate(string text, string sourceLang, string targetLang)
        {
            var translateTextRequest = _translateService.Projects.TranslateText(
                new Google.Apis.Translate.v3.Data.TranslateTextRequest()
                {
                    Contents = new List<string>() { text },
                    SourceLanguageCode = sourceLang,
                    TargetLanguageCode = targetLang,
                }, 
                $"projects/{_projectId}");

            var translateTextResponse = translateTextRequest.Execute();

            return translateTextResponse.Translations[0].TranslatedText;
        }
    }
}

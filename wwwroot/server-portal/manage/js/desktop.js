var Desktop = {
    options: {
        windowArea: ".window-area",
        windowAreaClass: "",
        taskBar: ".task-bar > .tasks",
        taskBarClass: ""
    },

    wins: {},

    setup: function(options){
        this.options = $.extend( {}, this.options, options );
        return this;
    },

    addToTaskBar: function(wnd){
        var icon = wnd.getIcon();
        var wID = wnd.win.attr("id");
        var item = $("<span>").addClass("task-bar-item started c-pointer supertop").html(icon);

        item.data("wID", wID);

        item.on("click", function () {
            $("#"+item.data("wID")).toggle();
        });

        item.appendTo($(this.options.taskBar));
    },

    removeFromTaskBar: function(wnd){
        var wID = wnd.attr("id");
        var items = $(".task-bar-item");
        var that = this;
        $.each(items, function(){
            var item = $(this);
            if (item.data("wID") === wID) {
                delete that.wins[wID];
                item.remove();
            }
        })
    },

    createWindow: function(o){
        o.onDragStart = function(){
            win = $(this);
            $(".window").css("z-index", 10000);

            if (!win.hasClass("modal")) {
                win.css("z-index", 10002);
            }
        };
        o.onDragStop = function(){
            win = $(this);
            if (!win.hasClass("modal"))
                win.css("z-index", 10001);
        };
        o.onWindowDestroy = function(win){
            Desktop.removeFromTaskBar($(win));
        };



        var w = $("<div>").appendTo($(this.options.windowArea));
        var wnd = w.window(o).data("window");

        var win = wnd.win;
        var shift = Metro.utils.objectLength(this.wins) * 16;

        if (wnd.options.place === "auto" && wnd.options.top === "auto" && wnd.options.left === "auto") {
            win.css({
                top: shift,
                left: shift
            });
        }
        this.wins[win.attr("id")] = wnd;
        this.addToTaskBar(wnd);

        return wnd;
    }
};

Desktop.setup();

//function CreateStudioWindow(tool) {
//    var w = Desktop.createWindow({
//        resizeable: true,
//        draggable: true,
//        width: 1000,
//        height: '80%',
//        icon: tool.Icon,
//        title: tool.Name,
//        content: tool.InitContent,
//        onShow: tool.InitOnShow,
//        shadow: true,
//        clsCaption: "text-center",
//        clsContent:"h-100",
//        onClose: function (win) {
//            UnRegisterStudio(tool.Id);
//            var win = $(win);
//            win.addClass("ani-swoopOutTop");
//        }
//    });
//}


function OpenFrameWindow(tool) {
    let customButtons = [
        {
            html: "<span class='mif-help' title='Open Readme.md'></span>",
            cls: "success",
            onclick: `Gs.Objects.InfoboxFrameCreate('HelpViewer','${tool.Url}Readme', false);`
        },
        {
            html: "<span class='mif-help' title='Show Readme.md Code'></span>",
            cls: "warning",
            onclick: `Gs.Objects.InfoboxFrameCreate('HelpCodeViewer','${tool.Url}Readme.md', false);`
        },
        {
            html: "<span class='mif-file-code' title='Show Window Code'></span>",
            cls: "alert",
            onclick: `Gs.Behaviors.ShowWindowFrameWindowCode("FrameWindow_${tool.Id}");`
        },
        {
            html: "<span class='mif-windows' title='Open in External Window'></span>",
            cls: "sys-button",
            onclick: `Gs.Objects.WindowFrameOpenInExternalWindow("${tool.Url}");`
        },
        {
            html: "<span class='mif-vpn-publ' title='Show URL'></span>",
            cls: "sys-button",
            onclick: `alert(document.getElementById("FrameWindow_${tool.Id}").contentWindow.location.href);`
        },
        {
            html: "<span class='mif-backward' title='Back to URL'></span>",
            cls: "warning",
            onclick: `$(\"#FrameWindow_${tool.Id}").attr("src","${tool.Url}")`
        }
    ];


    var w = Desktop.createWindow({
        resizeable: true,
        draggable: true,
        customButtons: customButtons,
        width: "100%",
        height: '100%',
        icon: tool.Icon,
        title: tool.Title,
        content: tool.InitContent,
        onShow: tool.InitOnShow,
        btnMin: true,
        btnMax: true,
        shadow: true,
        cls: "p-0",
        clsCaption: "text-center bg-orange",
        clsContent: "h-100",
        clsWindow: "z-indexWindow",
        onShow: function (win) {
            var win = $(win);
            win.addClass("ani-swoopInTop");
            setTimeout(function () {
                $(win).removeClass("ani-swoopInTop");
            }, 1000);
        },
        onClose: function (win) {
            Gs.Functions.UnRegisterFrame(tool.Id);
            var win = $(win);
            win.addClass("ani-swoopOutTop");
        }
    });
}


//function OpenYoutubeVideo(){
//    Desktop.createWindow({
//        resizeable: true,
//        draggable: true,
//        width: 500,
//        icon: "<span class='mif-youtube'></span>",
//        title: "Youtube video",
//        content: "https://www.youtube.com/embed/RkPdCWGXEwY?list=PLmE7gP9LTBimNJQ444ypG8HVce23fa2Hb",
//        clsContent: "bg-dark",
//        onClose: function (win) {
//            var win = $(win);
//            win.addClass("ani-swoopOutTop");
//        }
//    });
//}


//$(".window-area").on("click", function(){
//    Metro.charms.close("#charm");
//});

//$(".charm-tile").on("click", function(){
//    $(this).toggleClass("active");
//});

//Start Panel

var setTilesAreaSize = function () {
    var width = (window.innerWidth > 0) ? window.innerWidth : screen.width;
    var groups = $(".tiles-group");
    var tileAreaWidth = 80;
    $.each(groups, function () {
        if (width <= Metro.media_sizes.LD) {
            tileAreaWidth = width;
        } else {
            tileAreaWidth += $(this).outerWidth() + 80;
        }
    });

    $(".tiles-area").css({  width: tileAreaWidth });

    if (width > Metro.media_sizes.LD) {
        $(".start-screen").css({
            overflow: "auto"
        })
    }
};

setTilesAreaSize();
$.each($('[class*=tile-]'), function () {
    var tile = $(this);
    setTimeout(function () {
        tile.css({
            opacity: 1,
            "transform": "scale(1)",
            "transition": ".3s"
        }).css("transform", false);

    }, Math.floor(Math.random() * 500));
});

$(".tiles-group").animate({  left: 0 });

$("#StartPanel").on(Metro.events.resize + "-start-screen-resize", function () { setTilesAreaSize(); });

$("#StartPanel").on(Metro.events.mousewheel, function (e) {
    var up = e.deltaY < 0 ? -1 : 1;
    var scrollStep = 50;
    $(".start-screen")[0].scrollLeft += scrollStep * up;
});
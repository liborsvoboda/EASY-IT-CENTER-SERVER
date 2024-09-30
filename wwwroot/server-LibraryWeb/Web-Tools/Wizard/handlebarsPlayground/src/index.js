//require("./main/main.scss"); this does not work with webpack
//require('handlebars/runtime'); does not load the module
//require("bootstrap");

document.addEventListener("DOMContentLoaded", function(event) {

    function createNews(options) {
        var sampleNews = {
            image: {
                base: "./dist/assets/img/sample.jpg",
                mobile: "./dist/assets/img/sample2.jpg"
            },
            category: "Hovercrafts",
            title: "My hovercraft is full of eels, because my hovercraft is full of eels",
            description: {
                created: new Date(),
                author: "Nánási Pál"
            },
            summary: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            href: "#somelink"
        };

        if (!options) {
            return sampleNews;
        }

        sampleNews.isTop = options.isTop;
        sampleNews.isFloating = options.isFloating;


        if (options && options.isImageLess) {
            delete sampleNews.image;
        }

        return sampleNews;
    }
    var context = {
        header: {
           title: "Scientific Béla",
           menuPoints: [
               {
                   name: "The sciences",
                   link: "#"
               },
               {
                   name: "Mind",
                   link: "#"
               }
           ]
        },
        latestNews: {
            topNews: createNews({isTop: true}),
            leftSideNews: [createNews(), createNews({isImageLess: true}), createNews()],
            rightSideNews: [
                createNews({isImageLess: true}),
                createNews({isImageLess: true}),
                createNews({isImageLess: true}),
                createNews({isImageLess: true}),
                createNews({isImageLess: true}),
                createNews({isImageLess: true})
            ]
        },
        mostPopular: {
            title: "Most popular",
            news: [
                createNews({isFloating: true}),
                createNews({isFloating: true}),
                createNews({isFloating: true}),
                createNews({isFloating: true}),
                createNews({isFloating: true})
            ]
        },
        specialReport: {
          title: "Special report",
          article: {
              title: "The great hovercraft of 2018",
              description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
              created: new Date()
          }
        },
        videos: {
            title: "Videos",
            items: [
                {title: "My hovercraft is full", description: "long long long long", created: new Date()},
                {title: "My hovercraft is full", description: "long long long long", created: new Date()},
                {title: "My hovercraft is full", description: "long long long long", created: new Date()},
                {title: "My hovercraft is full", description: "long long long long", created: new Date()},
                {title: "My hovercraft is full", description: "long long long long", created: new Date()}
            ]
        },
        currentIssue: {
            image: ""
        },
        footer: {
            value: "I am the footer"
        }
    };

    var mainTemplateSource   = document.getElementById("main-template").innerHTML;
    var mainTemplate = Handlebars.compile(mainTemplateSource);

    /* PARTIALS */
    // header
    var headerPartial = document.getElementById("header-partial").innerHTML;
    Handlebars.registerPartial("headerPartial", headerPartial);

    // footer
    var footerPartial = document.getElementById("footer-partial").innerHTML;
    Handlebars.registerPartial("footerPartial", footerPartial);

    // news
    var newsPartial = document.getElementById("news-partial").innerHTML;
    Handlebars.registerPartial("newsPartial", newsPartial);

    // section header
    var sectionHeaderPartial = document.getElementById("section-header-partial").innerHTML;
    Handlebars.registerPartial("sectionHeaderPartial", sectionHeaderPartial);

    /* HELPERS */
    Handlebars.registerHelper("newsDescriptionHelper", function (description) {
        return "September " + description.created.getDate() + ", 2017" + " — " + description.author;
    });

    /* render */
    var output = mainTemplate(context);
    document.body.insertAdjacentHTML("beforeend", output);
});

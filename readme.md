<body><h2>Movie DB Search</h2>
    <p class="textC">This is a movie search program in winforms.</p>
    <p class="textL" id="textL1">It uses the TMDB API:</p>
    <a href="https://www.themoviedb.org/" >
        <img class="imgR" id="tmdbLogo" alt="TMDB logo should be here" title="To TMDB" src=https://www.themoviedb.org/assets/2/v4/logos/v2/blue_square_1-5bdc75aaebeb75dc7ae79426ddd9be3b2be1e342510f8202baf6bffa71d7f5c4.svg />
    </a>
    <p class="textL" id="textL2">It also uses Newtonsoft's Json.net-library:</p>
    <a href="https://www.newtonsoft.com/json">
        <img class="imgR" id="newtonsoftLogo" alt="Newtonsoft logo should be here" title="To Netwonsoft" src=https://www.nuget.org/profiles/newtonsoft/avatar?imageSize=512 />
    </a>
    <p class="textL" id="textL3">Aaaand the dotenv.net library for handling environment variables:</p>
    <a href="https://github.com/bolorundurowb/dotenv.net">
        <img class="imgR" id="githubLogo" alt="Github logo should be here" title="To dotenv Github Repo" src=https://github.githubassets.com/images/modules/logos_page/GitHub-Mark.png />
    </a>
    <p class="textBox" id="textInstructions">To open project: .env file in root folder with your tmdb apikey as "APIKEY"</p>
    <p class="textBox" id="textBot">Created by me as part of a programming course at Handelsakademin in Gothenburg.</p>
</body>
<style>
    h2 {
        text-align: center;
        font-family: courier new;
        font-style: oblique;
    }
    body {
        background-color: #fff3cc;
    }
    p {
        font-family: courier new;
    }
    .textC {
        text-align: center;
    }
    .textL {
        position: fixed;
        width: 45%;
        text-align: center;
        display: block;
    }
    #textL1 {
        top: 160px;
    }
    #textL2 {
        top: 300px;
    }
    #textL3 {
        top: 470px;
    }
    .imgR {
        position: absolute;
        display: inline-block;
    }
    #tmdbLogo {
        top: 127px;
        left: 50%;
        width: 250px;
    }
    #newtonsoftLogo {
        top: 255px;
        left: 57%;
        height: 160px;
        width: auto;
    }
    #githubLogo {
        top: 430px;
        left: 57%;
        width: 160px;
    }
    .textBox {
        position: fixed;
        display: inline-block;
        text-align:center;
    }
    #textInstructions {
        left: 28%;
        bottom: 15%;
        width: 44%;
    }
    #textBot {
        left: 20%;
        bottom: 5%;
        width: 60%
    }
</style


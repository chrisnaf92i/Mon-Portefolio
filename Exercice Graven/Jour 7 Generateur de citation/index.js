const url = "Resource/citations.json"
let generateBtn = document.getElementById("generate");
let auther = document.getElementById("name");
let img = document.getElementById("image");
let citation = document.getElementById("citation");
let listCitation = [];
generateBtn.addEventListener("click", GenerateCitation);

fetch(url).then((data) => 
{
    data.json().then((data) =>
    {

        listCitation = data;
        console.log(listCitation);

    });
});


function GenerateCitation()
{
    let random = Math.floor(Math.random() * (listCitation.length-0));
    let randomCitation = listCitation[random];
    auther.textContent =  randomCitation["nom"];
    img.setAttribute("src", randomCitation["image"]);
    citation.textContent = randomCitation["citation"];
}


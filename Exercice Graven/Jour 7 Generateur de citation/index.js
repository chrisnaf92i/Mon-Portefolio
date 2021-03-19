let generateBtn = document.getElementById("generate");
let auther = document.getElementById("name");
let img = document.getElementById("image");
let citation = document.getElementById("citation");




generateBtn.addEventListener("click", GenerateCitation);

function GenerateCitation()
{
    auther.textContent = "Bill Gates";
    img.innerHTML = "<img src='images/billgates.jpg' alt='Avatar'>";
    citation.textContent = "Le logiciel est une excellente combinaison entre l'art et l'ingénieurie";

}


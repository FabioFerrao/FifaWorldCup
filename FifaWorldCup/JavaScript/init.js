document.addEventListener('DOMContentLoaded', function main(_) {
    
    //funcao chamada no init() para voltar para as categorias
    function retrocederParaGrupos() {

        //Um container 'sticky' para colocar o header com Bootstrap
        var headerContainer = document.createElement('div');
        headerContainer.className = "row";
        document.querySelector('#topBar').appendChild(headerContainer);


        var divImg = document.createElement('div');
        divImg.className = "col-3";
        divImg.style.border = "1px solid";
        headerContainer.appendChild(divImg);

        var imgLogo = document.createElement('img');
        imgLogo.src = "Imagens/Logo.png";
        imgLogo.style.width = "250px"
        imgLogo.style.height = "250px"
        divImg.appendChild(imgLogo);



        var divTitulo = document.createElement('div');
        divTitulo.className = "col-3";

        divTitulo.style.border = "1px solid";
        headerContainer.appendChild(divTitulo);

        var retroceder = document.createElement('h1');
        retroceder.textContent = "Fifa World Cup";
        divTitulo.appendChild(retroceder);
        headerContainer.onclick = function () {
            var selecoesList = document.querySelector('#selecoes');
            selecoesList.style.display = "none";
            var jogadoresList = document.querySelector('#jogadores');
            jogadoresList.style.display = "none";
            var selecoesList = document.querySelector('#selecaoDetalhes');
            selecoesList.style.display = "none";
            var jogadoresList = document.querySelector('#jogadorDetalhes');
            jogadoresList.style.display = "none";
            var gruposList = document.querySelector('#grupos');
            gruposList.style.display = "block";
            ecraGrupos();
        };
    }

    function init() {
        //botao de retroceder para os grupos
        retrocederParaGrupos();

        ecraGrupos();
    }

    init();
});
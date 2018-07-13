document.addEventListener('DOMContentLoaded', function main(_) {
    
    //funcao chamada no init() para voltar para as categorias
    function retrocederParaGrupos() {

        var divTitulo = document.createElement('div');
        divTitulo.className = "col-3";
        var retroceder = document.createElement('h1');
        retroceder.textContent = "Fifa World Cup";
        divTitulo.appendChild(retroceder);
        topBar.onclick = function () {
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
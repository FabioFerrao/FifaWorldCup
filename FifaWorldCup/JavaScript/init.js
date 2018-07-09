document.addEventListener('DOMContentLoaded', function main(_) {
    /*
    //funcao chamada no init() para voltar para as categorias
    function retrocederParaGrupos() {

        //Um container 'sticky' para colocar o header com Bootstrap
        var headerContainer = document.createElement('div');
        headerContainer.className = "col-11";
        document.querySelector('#topBar').appendChild(headerContainer);
        var retroceder = document.createElement('h1');
        retroceder.textContent = "Fifa World Cup";
        retroceder.onclick = function () {
            var detailList = document.querySelector('#detailPilot');
            detailList.style.display = "none";
            var multiPilot = document.querySelector('#multiPilot');
            multiPilot.style.display = "none";
            var pilotList = document.querySelector('#pilotList');
            pilotList.style.display = "none";
            var focusImageItem = document.querySelector('#focusImageItem');
            focusImageItem.style.display = "none";
            var catList = document.querySelector('#catList');
            catList.style.display = "block";
        };
        headerContainer.appendChild(retroceder);
    }

    function init() {
        //botao de retroceder para os grupos
        retrocederParaGrupos();

        ecraGrupos();
    }
    */
    function init() {
        ecraGrupos();
    }
    
    init();
});
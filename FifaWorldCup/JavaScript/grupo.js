function mostraGrupos(grupos) {

    //associacao dos divs a uma variavel para melhor utilização
    var gruposList = document.querySelector('#grupos');
    var selecoesList = document.querySelector('#selecoes');
    var jogadoresList = document.querySelector('#jogadores');
    var jogadorDetalhesList = document.querySelector('#jogadorDetalhes');
    var selecaoDetalhesList = document.querySelector('#selecaoDetalhes');

    //mostrar apenas o div correto
    gruposList.style.display = "block";
    selecoesList.style.display = "none";
    jogadoresList.style.display = "none";
    jogadorDetalhesList.style.display = "none";
    selecaoDetalhesList.style.display = "none";

    //limpar os divs
    jogadorDetalhesList.innerHTML = "";
    jogadoresList.innerHTML = "";
    selecaoDetalhesList.innerHTML = "";
    selecoesList.innerHTML = "";
    gruposList.innerHTML = "";
    gruposList.style.display = "flex";
    var divGrupo = document.createElement('div');
    divGrupo.className = "divConteudo row text-center";
    divGrupo.setAttribute("style", "justify-content:center;background-image:Imagens/Publico.png;");

    gruposList.appendChild(divGrupo);
    for (var i = 0; i < grupos.length; i++) {
        var grupo = grupos[i];
        var divPorGrupo = document.createElement('div');
        divPorGrupo.setAttribute("id", "divPorGrupo");
        divPorGrupo.setAttribute("data-grupoid", grupo.Id);
        divPorGrupo.className = "rounded col-md-2";
        divPorGrupo.style.cursor = "pointer";
        divGrupo.appendChild(divPorGrupo);
        
        var nome = document.createElement('h1');
        nome.textContent = grupos[i].Nome;
        divPorGrupo.appendChild(nome);
            
         //funcao para ir buscar as selecoes desse grupo
        divPorGrupo.onclick = function (e) {
            var groupID = this.getAttribute('data-grupoid');
            ecraSelecoes(groupID);
        };
    }
    
}

function getGrupos() {
    var url = "/api/Grupos";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter os grupos"));
            }
        });
}

function ecraGrupos() {
    return getGrupos()
        .then(function (grupos) {
            mostraGrupos(grupos);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}
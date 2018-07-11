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

    //limpar os restantes divs
    jogadorDetalhesList.innerHTML = "";
    jogadoresList.innerHTML = "";
    selecaoDetalhesList.innerHTML = "";
    selecoesList.innerHTML = "";
    gruposList.innerHTML = "";


    for (var i = 0; i < grupos.length; i++) {
        var grupo = grupos[i];
    
        var divGrupo = document.createElement('div');
        divGrupo.setAttribute("id", "divGrupo")
        divGrupo.setAttribute("data-grupoid", grupo.Id);
        gruposList.appendChild(divGrupo);
        
        var nome = document.createElement('h1');
        nome.textContent = grupos[i].Nome;
        divGrupo.appendChild(nome);
            
         //funcao para ir buscar as selecoes desse grupo
        divGrupo.onclick = function (e) {
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
function mostraGrupos(grupos) {
    var containerGrupos = document.querySelector('#grupos');


    var divGrupos = document.createElement('div');
    containerGrupos.appendChild(divGrupos);
    for (var i = 0; i < grupos.length; i++) {
        var grupo = grupos[i];
    
        var divGrupo = document.createElement('div');
        divGrupo.setAttribute("data-grupoid", grupo.id);
        divGrupos.appendChild(divGrupo);
        
        var nome = document.createElement('h1');
        nome.textContent = grupos[i].Nome;
        divGrupo.appendChild(nome);
            
         //funcao para ir buscar as selecoes desse grupo
        divGrupo.onclick = function (e) {
            var groupID = this.getAttribute('data-grupoid');
            ecraSelecoes(groupID);
            var groupList = document.querySelector('#grupos');
            groupList.style.display = "none";
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
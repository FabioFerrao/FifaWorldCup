function mostraSelecoes(selecoes) {

    var gruposList = document.querySelector('#grupos');
    var selecoesList = document.querySelector('#selecoes');
    var jogadoresList = document.querySelector('#jogadores');
    var selecaoDetalhesList = document.querySelector('#selecaoDetalhes');

    gruposList.style.display = "none";
    jogadoresList.style.display = "none";
    selecaoDetalhesList.style.display = "none";
    selecoesList.style.display = "block";

    jogadoresList.innerHTML = "";
    gruposList.innerHTML = "";
    selecaoDetalhesList.innerHTML = "";



    selecoesList.className = "row";
    selecoesList.style.display = "flex";

    selecoesList.style.marginLeft = "15%";
    selecoesList.style.marginRight = "15%";
    for (var i = 0; i < selecoes.length; i++) {

        var selecao = selecoes[i];

        var divSelecao = document.createElement('div');
        divSelecao.setAttribute("id", "divSelecao")
        divSelecao.className = "col-md-6 col-sm-6 text-center";
        divSelecao.setAttribute("data-selecaoid", selecao.Id);
        selecoesList.appendChild(divSelecao);


        //funcao para ir buscar os detalhes da selecao selecionada
        divSelecao.onclick = function (e) {
            var selecaoId = this.getAttribute('data-selecaoid');
            ecraSelecaoDetalhes(selecaoId);
        };

        var nome = document.createElement('h1');
        nome.textContent = selecao.Nome;
        divSelecao.appendChild(nome);
        
        var emblema = document.createElement('img');
        //emblema.style.width = "100%";
        //emblema.style.height = "100%";
        emblema.style.position = "center";
        emblema.style.marginBottom = "30px";
        emblema.src = "Imagens/Selecoes/" + selecao.Emblema;
        divSelecao.appendChild(emblema);
        
    }

}

function getSelecoes(idGrupo) {
    var url = "/api/Grupo/" + idGrupo + "/Selecoes";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter as Selecoes"));
            }
        });
}

function ecraSelecoes(selecoes) {
    return getSelecoes(selecoes)
        .then(function (selecoes) {
            mostraSelecoes(selecoes);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}
function mostraSelecoes(selecoes) {
    var containerSelecoes = document.querySelector('#selecoes');

    for (var i = 0; i < selecoes.length; i++) {

        var selecao = selecoes[i];

        var nome = document.createElement('h1');
        nome.textContent = selecao.Nome;
        containerSelecoes.appendChild(nome);

        var emblema = document.createElement('img');
        emblema.src = "~/Imagens/Selecoes/" + selecao.Emblema;
        containerSelecoes.appendChild(emblema);

        var divEstatisticaSelecao = document.createElement('div');
        containerSelecoes.appendChild(divEstatisticaSelecao);

        //Estatistica da Selecao
        for (var z = 0; z < selecao.EstatisticaS.length; z++) {

            var estatisticaS = selecao.EstatisticaS[z];

            var nomeEstatistica = document.createElement('h3');
            nomeEstatistica.textContent = estatisticaS.Nome;
            divEstatisticaSelecao.appendChild(nomeEstatistica);

            var valorEstatistica = document.createElement('p');
            valorEstatistica.textContent = estatisticaS.Valor;
            divEstatisticaSelecao.appendChild(valorEstatistica);

        }

        var divEquipamentosSelecao = document.createElement('div');
        containerSelecoes.appendChild(divEquipamentosSelecao);
        //Equipamentos da Selecao
        for (var j = 0; j < selecao.Equipamentos.length; j++) {

            var equipamento = selecao.Equipamentos[j];

            var nomeEstatistica = document.createElement('h3');
            nomeEstatistica.textContent = equipamento.Nome;
            divEquipamentosSelecao.appendChild(nomeEstatistica);

            var imgEquipamento = document.createElement('img');
            imgEquipamento.src = "~/Imagens/Selecoes/Equipamentos/" + equipamento.Imagem;
            divEquipamentosSelecao.appendChild(imgEquipamento);

        }

        var divJogadoresSelecao = document.createElement('div');
        containerSelecoes.appendChild(divJogadoresSelecao);
        //Jogadores da Selecao
        for (var k = 0; k < selecao.Jogadores.length; k++) {

            var jogador = selecao.Jogadores[k];

            var divJogador = document.createElement('div');
            divJogador.setAttribute("data-jogadorid", jogador.id);
            divGrupos.appendChild(divJogador);

            //funcao para ir buscar os jogadores dessa selecao
            divJogador.onclick = function (e) {
                var jogadorID = this.getAttribute('data-jogadorid');
                ecraJogadores(jogadorID);
                var selecoesList = document.querySelector('#selecoes');
                selecoesList.style.display = "none";
            };

            var nomeJogador = document.createElement('h3');
            nomeJogador.textContent = jogador.Nome;
            divJogadoresSelecao.appendChild(nomeJogador);

            var imgJogador = document.createElement('img');
            imgJogador.src = "~/Imagens/Jogadores/" + jogador.Imagem;
            divJogadoresSelecao.appendChild(imgJogador);
            
        }
    }

}

function getSelecoes() {
    var url = "/api/Selecoes";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter as Selecoes"));
            }
        });
}

function ecraSelecoes() {
    return getSelecoes()
        .then(function (selecoes) {
            mostraGrupos(selecoes);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}
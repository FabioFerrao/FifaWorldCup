function mostraSelecaoDetalhes(selecaoDetalhes) {
    var gruposList = document.querySelector('#grupos');
    var selecoesList = document.querySelector('#selecoes');
    var jogadoresList = document.querySelector('#jogadores');
    var selecaoDetalhesList = document.querySelector('#selecaoDetalhes');

    //mostrar apenas o div correto
    gruposList.style.display = "none";
    selecoesList.style.display = "none";
    jogadoresList.style.display = "none";
    selecaoDetalhesList.style.display = "block";

    //limpar os restantes divs
    jogadoresList.innerHTML = "";
    gruposList.innerHTML = "";
    selecoesList.innerHTML = "";

    for (var i = 0; i < selecaoDetalhes.length;i++){
        var selecDetalhes = selecaoDetalhes[i];


        var nome = document.createElement('h1');
        nome.textContent = selecDetalhes.Nome;
        selecaoDetalhesList.appendChild(nome);

        var emblema = document.createElement('img');
        emblema.src = "Imagens/Selecoes/" + selecDetalhes.Emblema;
        selecaoDetalhesList.appendChild(emblema);

        //Estatisticas da Selecao
        for (var k = 0; k < selecDetalhes.listaDeEstatisticaPorSelecao.length; k++) {
            var estatisticaSelecao = selecDetalhes.listaDeEstatisticaPorSelecao[k];

            var nomeEstatistica = document.createElement('h3');
            nomeEstatistica.textContent = estatisticaSelecao.Nome;
            selecaoDetalhesList.appendChild(nomeEstatistica);

            var valorEstatistica = document.createElement('p');
            valorEstatistica.textContent = estatisticaSelecao.Valor;
            selecaoDetalhesList.appendChild(valorEstatistica);
        }

        //Equipamentos da Selecao
        for (var k = 0; k < selecDetalhes.listaDeEquipamentosPorSelecao.length; k++) {
            var equipamento = selecDetalhes.listaDeEquipamentosPorSelecao[k];
            
            var imagemEquipamento = document.createElement('img');
            imagemEquipamento.src = "Imagens/Selecoes/Equipamentos/" + equipamento.Imagem;
            selecaoDetalhesList.appendChild(imagemEquipamento);

            var nomeEquipamento = document.createElement('h3');
            nomeEquipamento.textContent = equipamento.Nome;
            selecaoDetalhesList.appendChild(nomeEquipamento);

        }

        //Jogadores da Selecao
        for (var j = 0; j < selecDetalhes.listaDeJogadoresPorSelecao.length; j++) {
            var jogador = selecDetalhes.listaDeJogadoresPorSelecao[j];

            var nomeJogador = document.createElement('h1');
            nomeJogador.textContent = jogador.Nome;
            selecaoDetalhesList.appendChild(nomeJogador);

            var imgJogador = document.createElement('img');
            imgJogador.setAttribute("style", "width:180px; height:180px;");
            imgJogador.src = "Imagens/Jogadores/" + jogador.Imagem;
            selecaoDetalhesList.appendChild(imgJogador);

            var posicaoJogador = document.createElement('p');
            posicaoJogador.textContent = jogador.Posicao;
            selecaoDetalhesList.appendChild(posicaoJogador);

        }
    }



}

function getSelecaoDetalhes(selecaoDetalhes) {
    var url = "/api/Selecao/"+ selecaoDetalhes;

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter os Detalhes da Seleção"));
            }
        });
}

function ecraSelecaoDetalhes(selecaoDetalhes) {
    return getSelecaoDetalhes(selecaoDetalhes)
        .then(function (selecaoDetalhes) {
            mostraSelecaoDetalhes(selecaoDetalhes);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}
function mostraSelecaoDetalhes(selecaoDetalhes) {

    //associacao dos divs a uma variavel para melhor utilização
    var gruposList = document.querySelector('#grupos');
    var selecoesList = document.querySelector('#selecoes');
    var jogadoresList = document.querySelector('#jogadores');
    var jogadorDetalhesList = document.querySelector('#jogadorDetalhes');
    var selecaoDetalhesList = document.querySelector('#selecaoDetalhes');

    //mostrar apenas o div correto
    gruposList.style.display = "none";
    selecoesList.style.display = "none";
    jogadoresList.style.display = "none";
    jogadorDetalhesList.style.display = "none";
    selecaoDetalhesList.style.display = "block";

    //limpar os restantes divs

    jogadorDetalhesList.innerHTML = "";
    jogadoresList.innerHTML = "";
    gruposList.innerHTML = "";
    selecoesList.innerHTML = "";

    var selecDetalhes = selecaoDetalhes[0];

    selecaoDetalhesList.className = "row";
    selecaoDetalhesList.style.display = "flex";
    

    var divSelecaoDados = document.createElement('div');
    selecaoDetalhesList.appendChild(divSelecaoDados);
    divSelecaoDados.className = "col-md-4 col-sm-4";
    var nome = document.createElement('h1');
    nome.textContent = selecDetalhes.Nome;
    divSelecaoDados.appendChild(nome);

    var emblema = document.createElement('img');
    emblema.src = "Imagens/Selecoes/" + selecDetalhes.Emblema;
    divSelecaoDados.appendChild(emblema);


    var divEstatisticas = document.createElement('div');
    divEstatisticas.className = "row";
    divEstatisticas.id = "divEstatistica";
    divEstatisticas.style.display = "flex";

    divEstatisticas.style.marginLeft = "2%";
    divEstatisticas.style.marginRight = "15%";
    divEstatisticas.style.marginTop = "40px";

    divSelecaoDados.appendChild(divEstatisticas);
    //Estatisticas da Selecao
    for (var k = 0; k < selecDetalhes.listaDeEstatisticaPorSelecao.length; k++) {
        var estatisticaSelecao = selecDetalhes.listaDeEstatisticaPorSelecao[k];

        var divPorEstatistica = document.createElement('div');
        divPorEstatistica.className = "col-md-6 col-sm-6";

        divPorEstatistica.class = "divPorEstatistica";

        divEstatisticas.appendChild(divPorEstatistica);
        
        var nomeEstatistica = document.createElement('h3');
        nomeEstatistica.textContent = estatisticaSelecao.Nome;
        divPorEstatistica.appendChild(nomeEstatistica);

        var valorEstatistica = document.createElement('p');
        valorEstatistica.textContent = estatisticaSelecao.Valor;
        divPorEstatistica.appendChild(valorEstatistica);
    }


    var divEquipamentos = document.createElement('div');
    divEquipamentos.className = "row";
    divEquipamentos.id = "divEquipamentos";
    divEquipamentos.style.display = "flex";

    divEquipamentos.style.marginLeft = "2%";
    divEquipamentos.style.marginRight = "15%";

    divSelecaoDados.appendChild(divEquipamentos);

    //Equipamentos da Selecao
    for (var k = 0; k < selecDetalhes.listaDeEquipamentosPorSelecao.length; k++) {
        var equipamento = selecDetalhes.listaDeEquipamentosPorSelecao[k];

        var divPorEquipamento = document.createElement('div');
        divPorEquipamento.className = "col-md-5 col-sm-4";

        divPorEquipamento.class = "divPorEquipamento";

        divEquipamentos.appendChild(divPorEquipamento);


        var imagemEquipamento = document.createElement('img');
        imagemEquipamento.src = "Imagens/Selecoes/Equipamentos/" + equipamento.Imagem;
        divPorEquipamento.appendChild(imagemEquipamento);
        imagemEquipamento.setAttribute("style", "width:109px; height:125px;");


        var nomeEquipamento = document.createElement('h3');
        nomeEquipamento.textContent = equipamento.Nome;
        divPorEquipamento.appendChild(nomeEquipamento);

    }

    var divSelecaoJogadores = document.createElement('div');
    divSelecaoJogadores.className = "col-md-8 col-sm-8";
    selecaoDetalhesList.appendChild(divSelecaoJogadores);


    var divJogadores = document.createElement('div');
    divJogadores.className = "row";
    divSelecaoJogadores.appendChild(divJogadores);

    //Jogadores da Selecao
    for (var j = 0; j < selecDetalhes.listaDeJogadoresPorSelecao.length; j++) {
        var jogador = selecDetalhes.listaDeJogadoresPorSelecao[j];

        var divJogador = document.createElement('div');
        divJogador.className = "col-md-3 col-sm-3";
        divJogador.setAttribute("id", "divJogador")
        divJogador.setAttribute("data-jogadorid", jogador.Id);
        divJogadores.appendChild(divJogador);

        var nomeJogador = document.createElement('h1');
        nomeJogador.textContent = jogador.Nome;
        divJogador.appendChild(nomeJogador);

        var imgJogador = document.createElement('img');
        imgJogador.setAttribute("style", "width:180px; height:180px;");
        imgJogador.src = "Imagens/Jogadores/" + jogador.Imagem;
        divJogador.appendChild(imgJogador);

        var posicaoJogador = document.createElement('p');
        posicaoJogador.textContent = jogador.Posicao;
        divJogador.appendChild(posicaoJogador);

        //funcao para ir buscar as selecoes desse grupo
        divJogador.onclick = function (e) {
            var jogadorID = this.getAttribute('data-jogadorid');
            ecraJogadorDetalhes(jogadorID);
        };

    }



}

function getSelecaoDetalhes(selecaoDetalhes) {
    var url = "/api/Selecao/" + selecaoDetalhes;

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
function mostraSelecaoDetalhes(selecaoDetalhes) {

    //associacao dos divs a uma variavel para mais facil utilização
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
    

    var divDetalhesSelecao = document.createElement('div');
    divDetalhesSelecao.id = "divDetalhesSelecao";
    selecaoDetalhesList.appendChild(divDetalhesSelecao);
    divDetalhesSelecao.className = "row";
    
    //nome e emblema da selecao
    var divEmblema = document.createElement('div');
    divDetalhesSelecao.appendChild(divEmblema);
    divEmblema.className = "col-md-3 col-sm-3 divEmblema";

    var nome = document.createElement('h1');
    nome.textContent = selecDetalhes.Nome;
    divEmblema.appendChild(nome);

    var emblema = document.createElement('img');
    emblema.src = "Imagens/Selecoes/" + selecDetalhes.Emblema;
    divEmblema.appendChild(emblema);


    //informacao restante da selecao ( Estatistica, equipamentos e posicao dos jogadores )
    var divInfoSelecao = document.createElement('div');
    divDetalhesSelecao.appendChild(divInfoSelecao);
    divInfoSelecao.className = "col-md-9 col-sm-9";


    var divInfoSelecaoDivisao = document.createElement('div');
    divInfoSelecao.appendChild(divInfoSelecaoDivisao);
    divInfoSelecaoDivisao.className = "row";

    var divEstatisticaEquipamento = document.createElement('div');
    divInfoSelecaoDivisao.appendChild(divEstatisticaEquipamento);
    divEstatisticaEquipamento.className = "col-md-4 col-sm-4 divEstatisticaEquipamento";
    var divEstatisticas = document.createElement('div');
    divEstatisticas.className = "row rounded";
    divEstatisticas.id = "divEstatistica";
    
    divEstatisticaEquipamento.appendChild(divEstatisticas);

    //Estatisticas da Selecao
    for (var k = 0; k < selecDetalhes.listaDeEstatisticaPorSelecao.length; k++) {
        var estatisticaSelecao = selecDetalhes.listaDeEstatisticaPorSelecao[k];
        var divPorEstatistica = document.createElement('div');
        divPorEstatistica.className = "col-md-6 col-sm-6 divPorEstatistica";
        
        divEstatisticas.appendChild(divPorEstatistica);

        var nomeEstatistica = document.createElement('h3');
        nomeEstatistica.textContent = estatisticaSelecao.Nome;
        divPorEstatistica.appendChild(nomeEstatistica);

        var valorEstatistica = document.createElement('p');
        valorEstatistica.textContent = estatisticaSelecao.Valor;
        divPorEstatistica.appendChild(valorEstatistica);
    }




    var divEquipamentos = document.createElement('div');
    divEquipamentos.className = "row rounded";
    divEquipamentos.id = "divEquipamentos";
    divEstatisticaEquipamento.appendChild(divEquipamentos);

    //Equipamentos da Selecao
    for (var k = 0; k < selecDetalhes.listaDeEquipamentosPorSelecao.length; k++) {
        var equipamento = selecDetalhes.listaDeEquipamentosPorSelecao[k];

        var divPorEquipamento = document.createElement('div');
        divPorEquipamento.className = "col-md-5 col-sm-5 divPorEquipamento";
        divEquipamentos.appendChild(divPorEquipamento);

        var imagemEquipamento = document.createElement('img');
        imagemEquipamento.src = "Imagens/Selecoes/Equipamentos/" + equipamento.Imagem;
        divPorEquipamento.appendChild(imagemEquipamento);

        var nomeEquipamento = document.createElement('h3');
        nomeEquipamento.textContent = equipamento.Nome;
        divPorEquipamento.appendChild(nomeEquipamento);

    }
    
    var divImagemPosicoes = document.createElement('div');
    divImagemPosicoes.className = "col-md-7 col-sm-7 divInfoSelecaoDivisao";
    divInfoSelecaoDivisao.appendChild(divImagemPosicoes);
    var imagemPosicoes = document.createElement('img');
    imagemPosicoes.className = "rounded";
    imagemPosicoes.src = "Imagens/Selecoes/Posicoes/" + selecDetalhes.ImagemPosicoes;
    divImagemPosicoes.appendChild(imagemPosicoes);


    var divJogadores = document.createElement('div');
    divJogadores.className = "row";
    divJogadores.id = "divJogadores";
    selecaoDetalhesList.appendChild(divJogadores);

    //Jogadores da Selecao
    for (var j = 0; j < selecDetalhes.listaDeJogadoresPorSelecao.length; j++) {
        var jogador = selecDetalhes.listaDeJogadoresPorSelecao[j];

        var divJogador = document.createElement('div');
        divJogador.className = "col-md-3 col-sm-3 divJogador";
        divJogador.setAttribute("data-jogadorid", jogador.Id);
        divJogadores.appendChild(divJogador);

        var nomeJogador = document.createElement('h1');
        nomeJogador.textContent = jogador.Nome;
        divJogador.appendChild(nomeJogador);

        var imgJogador = document.createElement('img');
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
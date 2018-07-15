function mostraJogadorDetalhes(jogador) {

    //associacao dos divs a uma variavel para melhor utilização
    var gruposList = document.querySelector('#grupos');
    var selecoesList = document.querySelector('#selecoes');
    var jogadoresList = document.querySelector('#jogadores');
    var jogadorDetalhesList = document.querySelector('#jogadorDetalhes');
    var selecaoDetalhesList = document.querySelector('#selecaoDetalhes');

    //mostrar apenas o div correto
    gruposList.style.display = "none";
    selecoesList.style.display = "none";
    selecaoDetalhesList.style.display = "none";
    jogadoresList.style.display = "none";
    jogadorDetalhesList.style.display = "flex";

    //limpar os divs
    selecaoDetalhesList.innerHTML = "";
    jogadoresList.innerHTML = "";
    gruposList.innerHTML = "";
    selecoesList.innerHTML = "";

    var jogDetalhes = jogador[0];
    jogadorDetalhesList.className = "row";

    var divInfoDetalhesJogador = document.createElement('div');
    jogadorDetalhesList.appendChild(divInfoDetalhesJogador);
    divInfoDetalhesJogador.className = "col-md-4 col-sm-4";

    var divBasicInfo = document.createElement('div');
    divBasicInfo.id = "divBasicInfo";
    divInfoDetalhesJogador.appendChild(divBasicInfo);

    var nomeJogador = document.createElement('h1');
    nomeJogador.textContent = jogDetalhes.Nome;
    divBasicInfo.appendChild(nomeJogador);

    var imagemJogador = document.createElement('img');
    imagemJogador.src = "Imagens/Jogadores/" + jogDetalhes.Imagem;
    divBasicInfo.appendChild(imagemJogador);

    var divEstatisticasJogadores = document.createElement('div');
    divEstatisticasJogadores.className = "row";
    divEstatisticasJogadores.id = "divEstatisticasJogadores";
    divInfoDetalhesJogador.appendChild(divEstatisticasJogadores);


    //Estatistica

    for (var i = 0; i < jogDetalhes.listaDeEstatisticaPorJogador.length; i++) {

        var divJogadorEstatistica = document.createElement('div');
        divJogadorEstatistica.className = "col-md-5 col-sm-5 divJogadorEstatistica";
        divEstatisticasJogadores.appendChild(divJogadorEstatistica);

        var jogadorEstatistica = jogDetalhes.listaDeEstatisticaPorJogador[i];

        var nomeEstatistica = document.createElement('h3');
        nomeEstatistica.textContent = jogadorEstatistica.Nome;
        divJogadorEstatistica.appendChild(nomeEstatistica);

        var valorEstatistica = document.createElement('p');
        valorEstatistica.textContent = jogadorEstatistica.Valor;
        divJogadorEstatistica.appendChild(valorEstatistica);

    }


    var divImagemPosicao = document.createElement('div');
    jogadorDetalhesList.appendChild(divImagemPosicao);
    divImagemPosicao.className = "col-md-8 col-sm-8";
    divImagemPosicao.id = "divImagemPosicao";

    var imagemPosicao = document.createElement('img');
    imagemPosicao.src = "Imagens/Jogadores/Posicoes/" + jogDetalhes.PosicaoImagem;

    imagemPosicao.className = "rounded";
    divImagemPosicao.appendChild(imagemPosicao);

}

function getJogadorDetalhes(jogadorDetalhes) {
    var url = "/api/Jogador/" + jogadorDetalhes;

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter os Detalhes do Jogador"));
            }
        });
}

function ecraJogadorDetalhes(jogador) {
    return getJogadorDetalhes(jogador)
        .then(function (jogador) {
            mostraJogadorDetalhes(jogador);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}
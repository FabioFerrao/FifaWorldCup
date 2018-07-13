function mostraJogadorDetalhes(jogador) {
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
    jogadorDetalhesList.style.display = "block";

    //limpar os restantes divs

    selecaoDetalhesList.innerHTML = "";
    jogadoresList.innerHTML = "";
    gruposList.innerHTML = "";
    selecoesList.innerHTML = "";

    var jogDetalhes = jogador[0];


    var nomeJogador = document.createElement('h1');
    nomeJogador.textContent = jogDetalhes.Nome;
    jogadorDetalhesList.appendChild(nomeJogador);

    var imagemJogador = document.createElement('img');
    imagemJogador.src = "Imagens/Jogadores/" + jogDetalhes.Imagem;
    jogadorDetalhesList.appendChild(imagemJogador);


    for (var i = 0; i < jogDetalhes.listaDeEstatisticaPorJogador.length; i++) {
        var jogadorEstatistica = jogDetalhes.listaDeEstatisticaPorJogador[i];
    

        var nomeEstatistica = document.createElement('h3');
        nomeEstatistica.textContent = jogadorEstatistica.Nome;
        jogadorDetalhesList.appendChild(nomeEstatistica);

        var valorEstatistica = document.createElement('p');
        valorEstatistica.textContent = jogadorEstatistica.Valor;
        jogadorDetalhesList.appendChild(valorEstatistica);

    }



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
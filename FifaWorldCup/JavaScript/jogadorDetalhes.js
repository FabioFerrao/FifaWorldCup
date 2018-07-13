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

    jogadorDetalhesList.className = "row";
    jogadorDetalhesList.style.display = "flex";


    var jogDetalhes = jogador[0];

    var divJogadorBasicInfo = document.createElement('div');
    jogadorDetalhesList.appendChild(divJogadorBasicInfo);
    divJogadorBasicInfo.className = "col-md-4 col-sm-4";

    divJogadorBasicInfo.textAlign = "center";

    var nomeJogador = document.createElement('h1');
    nomeJogador.textContent = jogDetalhes.Nome;
    divJogadorBasicInfo.appendChild(nomeJogador);

    var imagemJogador = document.createElement('img');
    imagemJogador.src = "Imagens/Jogadores/" + jogDetalhes.Imagem;
    imagemJogador.setAttribute("style", "width:180px; height:180px;");
    divJogadorBasicInfo.appendChild(imagemJogador);

    var divJogadorEstatisticas = document.createElement('div');
    jogadorDetalhesList.appendChild(divJogadorEstatisticas);
    divJogadorEstatisticas.className = "col-md-8 col-sm-8";

    var divEstatisticas = document.createElement('div');
    divEstatisticas.className = "row";
    divEstatisticas.style.justifyContent = "center";
    divEstatisticas.style.textAlign = "center";
    divJogadorEstatisticas.appendChild(divEstatisticas);


    //Estatistica

    for (var i = 0; i < jogDetalhes.listaDeEstatisticaPorJogador.length; i++) {

        var divJogadorEstatistica = document.createElement('div');
        divJogadorEstatistica.className = "col-md-5 col-sm-5";
        divJogadorEstatistica.class = "divJogadorEstatistica";
        divEstatisticas.appendChild(divJogadorEstatistica);

        var jogadorEstatistica = jogDetalhes.listaDeEstatisticaPorJogador[i];

        var nomeEstatistica = document.createElement('h3');
        nomeEstatistica.textContent = jogadorEstatistica.Nome;
        divJogadorEstatistica.appendChild(nomeEstatistica);

        var valorEstatistica = document.createElement('p');
        valorEstatistica.textContent = jogadorEstatistica.Valor;
        divJogadorEstatistica.appendChild(valorEstatistica);

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
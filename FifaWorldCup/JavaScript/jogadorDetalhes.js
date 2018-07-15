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
    jogadorDetalhesList.style.justifyContent = "center";
    jogadorDetalhesList.style.textAlign = "center";
    jogadorDetalhesList.style.paddingTop = "2%";

    var jogDetalhes = jogador[0];


    var divInfoDetalhesJogador = document.createElement('div');
    jogadorDetalhesList.appendChild(divInfoDetalhesJogador);
    divInfoDetalhesJogador.className = "col-md-4 col-sm-4";

    var divBasicInfo = document.createElement('div');
    divInfoDetalhesJogador.appendChild(divBasicInfo);
    divBasicInfo.style.justifyContent = "center";
    divBasicInfo.style.textAlign = "center";
    divBasicInfo.style.marginBottom = "30px";

    var nomeJogador = document.createElement('h1');
    nomeJogador.textContent = jogDetalhes.Nome;
    divBasicInfo.appendChild(nomeJogador);

    var imagemJogador = document.createElement('img');
    imagemJogador.src = "Imagens/Jogadores/" + jogDetalhes.Imagem;
    imagemJogador.setAttribute("style", "width:180px; height:180px;");
    divBasicInfo.appendChild(imagemJogador);

    var divEstatisticas = document.createElement('div');
    divEstatisticas.className = "row";
    divEstatisticas.style.justifyContent = "center";
    divEstatisticas.style.textAlign = "center";
    divInfoDetalhesJogador.appendChild(divEstatisticas);


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


    var divImagemPosicao = document.createElement('div');
    jogadorDetalhesList.appendChild(divImagemPosicao);
    divImagemPosicao.className = "col-md-8 col-sm-8";
    divImagemPosicao.style.marginBottom = "20px";

    var imagemPosicao = document.createElement('img');
    imagemPosicao.src = "Imagens/Jogadores/Posicoes/" + jogDetalhes.PosicaoImagem;

    imagemPosicao.className = "rounded";
    imagemPosicao.style.width = "60%";
    imagemPosicao.style.height = "520px";
    imagemPosicao.style.border = "1px solid";

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
function mostraJogadores(jogadores) {
    var containerJogadores = document.querySelector('#jogadores');

    for (var i = 0; i < jogadores.length; i++) {

        var nome = document.createElement('h1');
        nome.textContent = jogadores[i].Nome;
        containerJogadores.appendChild(nome);

        var imagem = document.createElement('img');
        imagem.src = "~/Imagens/Jogadores/" + jogadores[i].Imagem;
        containerJogadores.appendChild(imagem);


        var posicao = document.createElement('h4');
        posicao.textContent = jogadores[i].Posicao;
        containerJogadores.appendChild(nome);


        var divEstatisticaJogador = document.createElement('div');
        containerJogadores.appendChild(divEstatisticaJogador);

        //Estatistica da Selecao
        for (var j = 0; j < jogadores.EstatisticaJ.length; j++) {
            var nomeEstatistica = document.createElement('h3');
            nomeEstatistica.textContent = jogadores.EstatisticaJ[j].Nome;
            divEstatisticaJogador.appendChild(nomeEstatistica);

            var valorEstatistica = document.createElement('p');
            valorEstatistica.textContent = jogadores.EstatisticaJ[j].Valor;
            divEstatisticaJogador.appendChild(valorEstatistica);

        }
    }

}

function getJogadores() {
    var url = "/api/Jogadores";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter os Jogadores"));
            }
        });
}

function ecraJogadores() {
    return getJogadores()
        .then(function (jogadores) {
            mostraGrupos(jogadores);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}
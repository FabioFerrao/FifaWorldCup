function mostraGrupos(grupos) {

    //associacao dos divs a uma variavel para melhor utilização
    var gruposList = document.querySelector('#grupos');
    var selecoesList = document.querySelector('#selecoes');
    var jogadoresList = document.querySelector('#jogadores');
    var jogadorDetalhesList = document.querySelector('#jogadorDetalhes');
    var selecaoDetalhesList = document.querySelector('#selecaoDetalhes');

    //mostrar apenas o div correto
    gruposList.style.display = "col-md-12 col-sm-12";
    selecoesList.style.display = "none";
    jogadoresList.style.display = "none";
    jogadorDetalhesList.style.display = "none";
    selecaoDetalhesList.style.display = "none";

    //limpar os divs
    jogadorDetalhesList.innerHTML = "";
    jogadoresList.innerHTML = "";
    selecaoDetalhesList.innerHTML = "";
    selecoesList.innerHTML = "";
    gruposList.innerHTML = "";


    var divTransparente = document.createElement('div');
    divTransparente.className = "row divTransparente";
    gruposList.appendChild(divTransparente);
    

    var divVideo = document.createElement('div');
    divVideo.className = "row divVideo";
    gruposList.appendChild(divVideo);

    

    var video = document.createElement('iframe');
    video.id = "videoIntroducao";
    video.src = "https://www.youtube.com/embed/HaEvnuGfALI?rel=0&amp;controls=0&amp;showinfo=0&autoplay=1&loop=1&playlist=HaEvnuGfALI";
    video.allowFullscreen;
    video.allow = "autoplay";
    video.frameborder = "0";
    divVideo.appendChild(video);
    //div que contem todos os grupos
    var divConteudoGrupos = document.createElement('div');
    divConteudoGrupos.className = "divConteudoGrupos row text-center";
    gruposList.appendChild(divConteudoGrupos);

    for (var i = 0; i < grupos.length; i++) {

        var grupo = grupos[i];
        var divGrupo = document.createElement('div');

        divGrupo.setAttribute("id", "divGrupo");
        divGrupo.setAttribute("data-grupoid", grupo.Id);
        divGrupo.className = "rounded col-md-2, col-sm-2";
        divConteudoGrupos.appendChild(divGrupo);

        var nome = document.createElement('h1');
        nome.textContent = grupos[i].Nome;
        divGrupo.appendChild(nome);

        //funcao para ir buscar as selecoes desse grupo
        divGrupo.onclick = function (e) {
            var groupID = this.getAttribute('data-grupoid');
            ecraSelecoes(groupID);
        };
    }

}

function getGrupos() {
    var url = "/api/Grupos";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter os grupos"));
            }
        });
}

function ecraGrupos() {
    return getGrupos()
        .then(function (grupos) {
            mostraGrupos(grupos);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}
function MostrarLinha() {
    var linha = document.getElementsByClassName("table-view");
    for (var i = 0; i < linha.length; i++) {
        linha[i].classList.toggle('ativar');
    }
}
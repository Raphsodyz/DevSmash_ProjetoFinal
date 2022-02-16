function MostrarLinha() {
    var linha = document.getElementsByClassName("table-view");
    for (var i = 0; i < linha.length; i++) {
        linha[i].classList.toggle('ativar');
    }
}

function AlterarMenu(li) {
    var recebeLi = document.getElementsByClassName("current")
    for (var i = 0; i < recebeLi.length; i++) {
        recebeLi[i].classList.remove('current');
    }
    if (li == 1)
        document.getElementById("li_Cronos").classList.add("current");
    if (li == 2)
        document.getElementById("li_Blog").classList.add("current");
    if (li == 3)
        document.getElementById("li_Servicos").classList.add("current");
    if (li == 4)
        document.getElementById("li_About").classList.add("current");
    if (li == 5)
        document.getElementById("li_Administrador").classList.add("current");
}
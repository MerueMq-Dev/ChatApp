export function setScroll() {
    var divMessageContainerBase = document.getElementById('divMessageContainerBase');
    if (divMessageContainerBase != null)
        divMessageContainerBase.scrollTop = divMessageContainerBase.scrollHeight;
}

export function setTheme(themeName) {
    
    let newLink = document.createElement("link");
    newLink.setAttribute("id", "theme");
    newLink.setAttribute("rel", "stylesheet");
    newLink.setAttribute("type", "text/css");
    newLink.setAttribute("href", `css/app-${themeName}.css`);

    let head = document.getElementsByTagName("head")[0];
    head.querySelector("#theme").remove();

    head.appendChild(newLink);
}


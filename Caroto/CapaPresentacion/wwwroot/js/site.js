function showLog() {
    document.getElementById('logWindow').style.display = "flex";
}

function closeLog() {
    document.getElementById('logWindow').style.display = "none";
}

function cambiarStyle(variable) {
    var elemento = document.getElementById("H" + variable);
    var boton = document.getElementById("btn" + variable);

    if (elemento.className == "visible") {
        elemento.className = "invisible";
        boton.src = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAYAAAA7MK6iAAABOUlEQVRIS+2V7xHBQBDFpQMlKIEO6IASdEAFqIAO6IAO6IAOpANKsL8PZy6y7k/mTnzIzuyE3N572Ze9l6LXUhQt8fY64p8p/xdS96XdleQwU9s3wV0abLvjqdw8ZiI1sHP5ceCPTUzHj4zET8GeSNJ57Tjl7BqZd5rU5h5y8wAp4yRgMxtQm2okv0tyTREViV0ds5ZS8orEPmLWU0jOBDPJtXAZCFJfJQcN9S5l30gSqaOIKR5LnhsSM0wMlRohlrmVnYtIco7N26WadGz2IHmolTolNoAhHVPLe+aI+YL3icQXX2EoMTjIjeyu2Mji2kfKegwx9S7J8WC8WJ3iz4eJJf72IVHdydV5LDFYmqup7pSaGDzb1WofgBzv2GAi+V6SK5ZYhpDZNU2kjuVQ6zviJDKGgLQm9QsC7S0fn4YEFgAAAABJRU5ErkJggg==";

    }
    else if (elemento.className == "invisible") {
        elemento.className = "visible";
        boton.src = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAYAAAA7MK6iAAABO0lEQVRIS+2W7RHBQBCG6YAOogM6iA4oQQdUQAd0QAd0QAd0QAlKsM9MflzWJvfByR/vTCaTD/vsvnu30e91pH5H3N4f/DPnU60eSIb7KsuFnJ+xGaeCjwKaVbCLnKe/AC8FslWguVyfYuCxFRcS/CoHVrvC6okcj1B4LNi1WDOiLI8BWxZr+Epu7EKqDgWPJdjZsNhiYPnNBw8B008sLn3Bquf0eeR7NwS8kSBrXyD1HLuxvVE+MFVSrV7FIXmwt1lwptrAwOgr/U0RW2yYAmZIsJI/EUOF4fKmpooZh1j8DZlTzQJj8T2xr1ai5lSzwG3TKdUBFlntQ6LBIdMpFV6z3AUXEtH6AKSC9O9qlrvgUt5k++QUfxoOAFwwi4otROU5RMVMs4cG54A1xvSNzGzJ/MHZrNWBO7P6BcqXKh+/zTFjAAAAAElFTkSuQmCC";

    }
}
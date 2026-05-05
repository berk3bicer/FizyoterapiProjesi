document.addEventListener('DOMContentLoaded', function () {
    var navbarCollapse = document.querySelector('.navbar-collapse');
    if (!navbarCollapse) return;

    navbarCollapse.addEventListener('show.bs.collapse', function () {
        document.body.classList.add('menu-open');
    });

    navbarCollapse.addEventListener('hide.bs.collapse', function () {
        document.body.classList.remove('menu-open');
    });
});

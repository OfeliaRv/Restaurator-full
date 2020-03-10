$(window).scroll(function () {
   if ($(this).scrollTop() > 610) {
      $('#nav-bar').addClass('nav-scrolled');
   } else {
      $('#nav-bar').removeClass('nav-scrolled');
   }

   if ($(this).scrollTop() > 280) {
      $('#nav-bar-auth').addClass('nav-scrolled');
   } else {
      $('#nav-bar-auth').removeClass('nav-scrolled');
   }
});
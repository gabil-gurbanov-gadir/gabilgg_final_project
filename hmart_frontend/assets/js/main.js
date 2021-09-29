$(document).ready(function () {
  if ($(window).scrollTop() >= 250) {
    if ($(window).width() < 993) {
      $("#sticky-header-bottom").addClass("fixed animate__fadeInDown");
    } else if ($(window).width() >= 993) {
      $("#header-nav-menu").addClass("fixed animate__fadeInDown");
    }
  } else {
    $("#sticky-header-bottom").removeClass("fixed animate__fadeInDown");
    $("#header-nav-menu").removeClass("fixed animate__fadeInDown");
  }

  $(window).scroll(function () {
    if ($(window).scrollTop() >= 250) {
      if ($(window).width() < 993) {
        $("#sticky-header-bottom").addClass("fixed animate__fadeInDown");
      } else if ($(window).width() >= 993) {
        $("#header-nav-menu").addClass("fixed animate__fadeInDown");
      }
    } else {
      $("#sticky-header-bottom").removeClass("fixed animate__fadeInDown");
      $("#header-nav-menu").removeClass("fixed animate__fadeInDown");
    }
  });

  $(document).on("click", "#wishlist-button", function (e) {
    e.preventDefault();
    $("body").addClass("canvas-opening");
    $("#shadow-layout").removeClass("d-none");
    $("#wishlist .list-wrapper").addClass("canvas-opening");
  });

  $(document).on(
    "click",
    "#wishlist .canvas-close, #shadow-layout",
    function (e) {
      e.preventDefault();
      $("body").removeClass("canvas-opening");
      $("#shadow-layout").addClass("d-none");
      $("#wishlist .list-wrapper").removeClass("canvas-opening");
    }
  );

  $(document).on("click", "#cartlist-button", function (e) {
    e.preventDefault();
    $("body").addClass("canvas-opening");
    $("#shadow-layout").removeClass("d-none");
    $("#cart .list-wrapper").addClass("canvas-opening");
  });

  $(document).on("click", "#cart .canvas-close, #shadow-layout", function (e) {
    e.preventDefault();
    $("body").removeClass("canvas-opening");
    $("#shadow-layout").addClass("d-none");
    $("#cart .list-wrapper").removeClass("canvas-opening");
  });

  $(document).on("click", "#menu-button", function (e) {
    e.preventDefault();
    $("body").addClass("canvas-opening");
    $("#shadow-layout").removeClass("d-none");
    $("#mobile-menu .menu").addClass("canvas-opening");
    $("#mobile-menu .canvas-close").addClass("move");
  });

  $(document).on(
    "click",
    "#mobile-menu .canvas-close, #shadow-layout",
    function (e) {
      e.preventDefault();
      $("body").removeClass("canvas-opening");
      $("#shadow-layout").addClass("d-none");
      $("#mobile-menu .menu").removeClass("canvas-opening");
      $("#mobile-menu .canvas-close").removeClass("move");
    }
  );

  var swiper = new Swiper(".main-slider", {
    direction: "vertical",
    speed: 2000,
    autoplay: {
      delay: 7000,
      disableOnInteraction: false,
    },
    loop: true,
    navigation: {
      nextEl: ".swiper-button-next",
      prevEl: ".swiper-button-prev",
    },
  });

  if ($(window).scrollTop() >= 350) {
    $("#scrollUp").removeClass("d-none");
    setTimeout(() => {
      $("#scrollUp").addClass("show");
    }, 100);
  } else {
    $("#scrollUp").removeClass("show");
    setTimeout(() => {
      $("#scrollUp").addClass("d-none");
    }, 100);
  }

  $(window).scroll(function () {
    if ($(window).scrollTop() >= 350) {
      $("#scrollUp").removeClass("d-none");
      setTimeout(() => {
        $("#scrollUp").addClass("show");
      }, 100);
    } else {
      $("#scrollUp").removeClass("show");
      setTimeout(() => {
        $("#scrollUp").addClass("d-none");
      }, 100);
    }
  });

  $(document).on("click", "#scrollUp", function (e) {
    e.preventDefault();
    $("html, body").animate({ scrollTop: 0 }, 1000);
  });
});

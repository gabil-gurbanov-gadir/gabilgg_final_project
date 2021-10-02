$(window).on("load", function () {
  $("#loading").hide();
});

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

  $("[data-countdown]").each(function () {
    $(this).countdown($(this).attr("data-countdown"), function (event) {
      $(this).html(
        event.strftime(
          '<span class="cdown day"><span class="cdown-1">%d</span><p>Days</p></span> <span class="cdown hour"><span class="cdown-1">%-H</span><p>Hrs</p></span> <span class="cdown minutes"><span class="cdown-1">%M</span> <p>Min</p></span> <span class="cdown second"><span class="cdown-1"> %S</span> <p>Sec</p></span>'
        )
      );
    });
  });
});

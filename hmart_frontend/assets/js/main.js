// Loading start
$(window).on("load", function () {
  $("#loading").hide();
});
// Loading end

$(document).ready(function () {
  //#region Sticky fixed
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
  //#endregion

  //#region Canvas

  //#region Wishlist
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
  //#endregion

  //#region CartList
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
  //#endregion

  //#region Mobile-menu
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
  //#endregion

  //#endregion

  // Main Slider start
  var mainSlider = new Swiper(".main-slider", {
    direction: "vertical",
    speed: 2000,
    autoplay: {
      delay: 7000,
      disableOnInteraction: !1,
    },
    loop: !0,
    navigation: {
      nextEl: ".swiper-button-next",
      prevEl: ".swiper-button-prev",
    },
    simulateTouch: !1,
  });
  // Main Slider end

  //#region Scroll Up Button
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
  //#endregion

  // Countdown Time start
  $("[data-countdown]").each(function () {
    $(this).countdown($(this).attr("data-countdown"), function (event) {
      $(this).html(
        event.strftime(
          '<span class="cdown day"><span class="cdown-1">%d</span><p>Days</p></span> <span class="cdown hour"><span class="cdown-1">%-H</span><p>Hrs</p></span> <span class="cdown minutes"><span class="cdown-1">%M</span> <p>Min</p></span> <span class="cdown second"><span class="cdown-1"> %S</span> <p>Sec</p></span>'
        )
      );
    });
  });
  // Countdown Time end

  // Testimonial Slider start
  var swiper = new Swiper(".testimonial-slider", {
    slidesPerView: 2,
    spaceBetween: 30,
    speed: 1500,
    loop: !0,
    navigation: {
      nextEl: ".swiper-button-next",
      prevEl: ".swiper-button-prev",
    },
    breakpoints: {
      0: { slidesPerView: 1 },
      478: { slidesPerView: 1 },
      576: { slidesPerView: 1 },
      768: { slidesPerView: 2 },
      992: { slidesPerView: 2 },
      1200: { slidesPerView: 2 },
    },
  });
  // Testimonial Slider end

  // Partners start
  var swiper = new Swiper(".partners-slider", {
    slidesPerView: 4,
    speed: 1500,
    loop: !0,
    autoplay: { delay: 2e3, disableOnInteraction: !1 },
    breakpoints: {
      0: { slidesPerView: 1 },
      480: { slidesPerView: 2 },
      768: { slidesPerView: 2 },
      992: { slidesPerView: 3 },
      1200: { slidesPerView: 4 },
    },
  });
  // Partners end

  // Modals start

  $(document).on("click", ".modal", function (e) {
    let target = $(e.target);
    if (target.hasClass("modal")) {
      $("#shadow-layout").removeClass("show");
      $(".modal").removeClass("show");
      setTimeout(() => {
        $("#shadow-layout").addClass("d-none");
        $(".modal").removeClass("fade");
        $("body").removeClass("canvas-opening");
      }, 600);
    }
  });

  $(document).on("click", ".btn-close", function (e) {
    e.preventDefault();
    $("#shadow-layout").removeClass("show");
    $(".modal").removeClass("show");
    setTimeout(() => {
      $("#shadow-layout").addClass("d-none");
      $(".modal").removeClass("fade");
      $("body").removeClass("canvas-opening");
    }, 600);
  });

  $(document).on("click", ".add-to-cart", function (e) {
    e.preventDefault();
    $("body").addClass("canvas-opening");
    $("#shadow-layout").removeClass("d-none");
    $("#cart-modal").addClass("fade");
    setTimeout(() => {
      $("#shadow-layout").addClass("show");
      $("#cart-modal").addClass("show");
    }, 300);
  });

  $(document).on("click", ".wishlist", function (e) {
    e.preventDefault();
    $("body").addClass("canvas-opening");
    $("#shadow-layout").removeClass("d-none");
    $("#wishlist-modal").addClass("fade");
    setTimeout(() => {
      $("#shadow-layout").addClass("show");
      $("#wishlist-modal").addClass("show");
    }, 300);
  });

  $(document).on("click", ".quickview", function (e) {
    e.preventDefault();
    $("body").addClass("canvas-opening");
    $("#shadow-layout").removeClass("d-none");
    $("#quickview-modal").addClass("fade");
    setTimeout(() => {
      $("#shadow-layout").addClass("show");
      $("#quickview-modal").addClass("show");
    }, 300);
  });

  // Modal slider start

  var modalSmallSlider = new Swiper(".modal-view-small-slider", {
    spaceBetween: 10,
    slidesPerView: 3,
    freeMode: !0,
    watchSlidesVisibility: !0,
    watchSlidesProgress: !0,
    navigation: {
      nextEl: ".swiper-button-next",
      prevEl: ".swiper-button-prev",
    },
  });

  var modalBigSlider = new Swiper(".modal-view-big-slider", {
    spaceBetween: 0,
    loop: !0,
    slidesPerView: 1,
    centerMood: !0,
    thumbs: { swiper: modalSmallSlider },
  });
  // Modal slider end

  // Modals end

  // Shop range start
  $("#slider-range").slider({
    range: true,
    min: 0,
    max: 2000,
    values: [400, 1600],
    slide: function (event, ui) {
      $("#amount").val("$" + ui.values[0] + " - $" + ui.values[1]);
    },
  });
  $("#amount").val(
    "$" +
      $("#slider-range").slider("values", 0) +
      " - $" +
      $("#slider-range").slider("values", 1)
  );
  // Shop range end

  //Dropdown Sort start
  $(document).on("click", ".header-action-btn", function (e) {
    e.preventDefault();
    $(".dropdown-menu").toggleClass("show");
  });
  $(document).on("click", function (e) {
    e.preventDefault();
    let target = $(e.target);
    if (!target.hasClass("header-action-btn")) {
      $(".dropdown-menu").removeClass("show");
    }
    // console.log("doc clik");
  });
  //Dropdown Sort end
});

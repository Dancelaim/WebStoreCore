    ! function(i) {
      var o, n;
      i(".acc-head").on("click", function() {
        o = i(this).parents(".acc-block"), n = o.find(".acc-body"),
          o.hasClass("active_block") ? (o.removeClass("active_block"),
            n.slideUp()) : (o.addClass("active_block"), n.stop(!0, !0).slideDown(),
            o.siblings(".active_block").removeClass("active_block").children(
              ".acc-body").stop(!0, !0).slideUp())
      })
    }(jQuery);

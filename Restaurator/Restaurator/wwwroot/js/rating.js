(function ($) {
    function Rating() {
        var $this = this;
        function initialize() {
            $(".star").click(function () {
                $(".star").removeClass('active');
                $(this).addClass('active');
                var starValue = $(this).data("value");
                $("#Rating").val(starValue);
            })
        }
        $this.init = function () {
            initialize();
        }
    }
    $(function () {
        var self = new Rating();
        self.init();
    })
}(jQuery))
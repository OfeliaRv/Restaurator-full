//Rating error message 
<script>
    $("#submitComment").click(function () {
        $("input[type=radio]").each(function () {
            if (document.querySelectorAll('input[type="radio"]:checked').length === 0) {
                $("#msg").html(
                    "<span class='text-danger' style='position: relative;bottom: 20px;' id='error'>"
                    + "Please rate!</span>");
            }
        });
});
</script> 
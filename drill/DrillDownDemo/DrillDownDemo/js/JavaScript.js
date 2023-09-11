


    $(document).ready(function () {
        $(".collapse.expand-btn").click(function () {
            $(this).closest("tr").next(".expand").toggle();
            $(this).toggleClass("collapse-btn").toggleClass("expand-btn");
        });

        $(".expand.collapse-btn").click(function () {
            $(this).closest("tr").next(".expand").toggle();
            $(this).toggleClass("expand-btn").toggleClass("collapse-btn");
        });
    })



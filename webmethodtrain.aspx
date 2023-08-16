<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webmethodtrain.aspx.cs" Inherits="WebApplication1.webmethodtrain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">



    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js" type="text/javascript"></script>


    <script src="../Jquery/jquery.multiselect.js"></script>
    <script src="../Jquery/prettify.js"></script>

    <!-- Basic HTML structure with core functionality -->
<div>
  <p>This is a basic webpage.</p>
</div>

<!-- Additional functionality for browsers that support it -->
<script>
    if ('serviceWorker' in navigator) {
        // Register a service worker for enhanced offline capabilities
        navigator.serviceWorker.register('/service-worker.js').then(function (registration) {
            console.log('Service Worker registered.');
        }).catch(function (error) {
            console.log('Service Worker registration failed:', error);
        });
    }

</script>
    <script>if (navigator.userAgentData) {
            // Use navigator.userAgentData to access browser information
            const browserName = navigator.userAgentData.brands[0].brand;
            const browserVersion = navigator.userAgentData.brands[0].version;
            console.log(`Browser: ${browserName}, Version: ${browserVersion}`);
        } else {
            // Fallback if navigator.userAgentData is not available
            const userAgent = navigator.userAgent;
            console.log(`Fallback: User Agent: ${userAgent}`);
        }
    </script>

<script>
    if ('geolocation' in navigator) {
        // Geolocation is supported, proceed with using it
        navigator.geolocation.getCurrentPosition(function (position) {
            // Handle the position data
        });
    } else {
        // Geolocation is not supported, provide an alternative or fallback
        console.log("Geolocation is not supported in this browser.");
    }


    $(document).ready(function () {

        $('#btn').click(function () {

            var name = $('#name').val();
            console.log(name);

            jQuery.ajax({

                url: 'webtmethodtrain.aspx/GetData()',

                type: "POST",

                dataType: "json",

                data: "{'name': '" + name + "'}",

                contentType: "application/json; charset=utf-8",
                beforeSend: function (xhr) {
                    console.log("check ");
                },
                success: function (data) {

                    alert(JSON.stringify(data));

                }

            });

        });

    });

</script>




Name:-<input type="text" name="name" id="name"  autocomplete="off"/>

<input type="button" name="btn1" id="btn" value="ClickMe" />


</asp:Content>

<?php

include_once 'header.php';

?>



<h1>Stationery Application</h1>

    <body class="bg-info">
    <div class="container-fluid col-md-10 offset-md-1">
        <div class="row">
            <div class=’card mt-3 px-2 py-2’>

            </div>

        </div>

    </div>

    <div>
        <form action = "landingpage.php" method="POST">



        <label for="Name">Name</label<br>
        <input name="Name" id="Name" type="text"><br>

        <label for="Postcode">Postcode</label<br>
        <input name="Postcode" id="name" type="text" required><br>

        <label for="Email">Email</label<br>
        <input name="Email" id="name" type="text"><br>


        <button>submit</button>


        </form>
    </div>

    </body>

<?php include_once 'footer.php';?>

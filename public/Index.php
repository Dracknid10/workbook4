<?php

include_once 'header.php';

?>

<h1>Stationery Application</h1>
<p>Welcome to this fictional stationery
    application page created for ISAD251 example. To continue please accept our terms and conditions</p>


<body class="bg-info">
<div class="container-fluid col-md-10 offset-md-1">
    <div class="row">
        <div class=’card mt-3 px-2 py-2’>

        </div>

    </div>

</div>

<div>
    <form action = "agreement.php" method="get">

        <input type="radio" id="true" name="decision" value="true">
        <label for="true">I agree</label><br>

        <input type="radio" id="false" name="decision" value="false">
        <label for="false">I disagree</label><br>

        <button>submit</button>



<br>
<a href="http://localhost/workbook4/public/registrationPanel.php" target="_blank"> OPEN REGISTRATION</a>




</div>

</body>

<?php include_once 'footer.php';?>

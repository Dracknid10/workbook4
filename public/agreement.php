<?php

include_once 'header.php';

?>


<body class="bg-info">
<div class="container-fluid col-md-10 offset-md-1">
    <div class="row">
        <div class=’card mt-3 px-2 py-2’>

        </div>

    </div>

</div>

<?php

$decision= $_GET ['decision'];

echo 'You have selected ';
echo $decision;
echo ' for the agreement';


?>

</body>
<?php include_once 'footer.php';?>
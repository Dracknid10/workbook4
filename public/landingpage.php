
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

$name= $_POST ['Name'];
$postcode= $_POST ['Postcode'];
$Email= $_POST ['Email'];

if(empty($name))
{
    echo 'greetings, your postcode is ';
    echo $postcode;
    echo ' and your email is ';
    echo $Email;
}
else
{
    echo 'hello ' ;
    echo $name;
    echo ' your postcode is ';
    echo $postcode;
    echo ' and your email is';
    echo $Email;
}





?>

</body>

<?php include_once 'footer.php';?>
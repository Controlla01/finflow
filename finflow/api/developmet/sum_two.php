<?php require_once 'config/connection.php'; ?>
<?php

$firstNumber = ($_POST['firstNumber']);
$secondNumber = ($_POST['secondNumber']);

// Validations
if ($firstNumber === '') {
    $response = [
        'response' => 100,
        'success' => false,
        'message' => "firstNumber is required."
    ];
    goto end;
}

if (!is_numeric($firstNumber)) {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "firstNumber must be a valid number."
    ];
    goto end;
}

if ($secondNumber === '') {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "secondNumber is required."
    ];
    goto end;
}

if (!is_numeric($secondNumber)) {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "secondNumber must be a valid number."
    ];
    goto end;
}

$sum = $firstNumber + $secondNumber;

$response = [
    'response' => 200,
    'success' => true,
    'sum' => $sum,
    'descriptionOne' => "The sum of $firstNumber and $secondNumber is $sum",
    'descriptionTwo' => "$firstNumber + $secondNumber = $sum"
];

end:
echo json_encode($response);
?>

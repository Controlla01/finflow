<?php require_once 'config/connection.php'; ?>

<?php

$radius = ($_POST['radius']);

// Secu
if ($radius === "") {
    $response = [
        'response' => 100,
        'success' => false,
        'message' => "Please enter radius"
    ];
    goto end;
}

if (!is_numeric($radius)) {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "Radius must be a number"
    ];
    goto end;
}

if ($radius <= 0) {
  $response = [
    'response' => 102,
    'success' => false,
    'message' => "Invalid value! Radius must be greater than zero."
  ];
  goto end;

}

// Calcu
$circumference = 2 * 3.142 * $radius;

$response = [
    'response' => 200,
    'success' => true,
    'circumference' => $circumference,
    'descriptionOne' => "The circumference of a circle with radius $radius is $circumference"
];

end:
echo json_encode($response);

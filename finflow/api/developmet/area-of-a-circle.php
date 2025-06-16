<?php require_once 'config/connection.php'; ?>
<?php

$radius = trim($_POST['radius']);

if ($radius === '') {
    $response = [
      'response' => 100,
      'success' => false,
      'message' => "RADIUS IS REQUIRED! Provide value for radius."
    ];
  goto end;
}

if (!is_numeric($radius)) {
  $response = [
      'response' => 101,
      'success' => false,
      'message' => "Invalid input! Radius must be a number."
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

// Calculations
$area = 3.142 * $radius * $radius;

$response = [
  'response' => 200,
  'success' => true,
  'radius' => $radius,
  'area' => round($area, 2), 
  'descriptionOne' => "The area of the circle with radius $radius is " . round($area, 2)
];


end:
echo json_encode($response);
?>
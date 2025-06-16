<?php require_once 'config/connection.php'; ?>

<?php

$a = trim($_POST['a']);
$b = trim($_POST['b']);
$c = trim($_POST['c']);

if ($a === '') {
    $response = [
        'response' => 100,
        'success' => false,
        'message' => "Missing input: please enter value for 'a'."
    ];
    goto end;
}

if (!is_numeric($a)) {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "Invalid input: 'a' must be a number."
    ];
    goto end;
}

if ($b === '') {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "Missing input: please enter value for 'b'."
    ];
    goto end;
}

if (!is_numeric($b)) {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "Invalid input: 'b' must be a number."
    ];
    goto end;
}

if ($c === '') {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "Missing input: please enter value for 'c'."
    ];
    goto end;
}

if (!is_numeric($c)) {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "Invalid input: 'c' must be a number."
    ];
    goto end;
}

if ($a == 0) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "Invalid input: 'a' cannot be zero."
    ];
    goto end;
}


$d = $b * $b;       
$e = 4 * $a * $c;   
$f = $d - $e;       

if ($f < 0) {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "No real solution: discriminant is negative."
    ];
    goto end;
}


$g = sqrt($f);
$j = 2 * $a;
$h = -$b + $g;
$i = -$b - $g;

$k = $h / $j;
$l = $i / $j;

$response = [
    'response' => 200,
    'success' => true,
    'a' => $a,
    'b' => $b,
    'c' => $c,
    'x1' => round($k, 2),
    'x2' => round($l, 2),
    'descriptionOne' => "x1 is " . round($k, 2) . " and x2 is " . round($l, 2)
];

end:
echo json_encode($response);
?>

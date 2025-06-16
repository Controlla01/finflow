<?php require_once 'config/connection.php'; ?>

<?php

$v1 = ($_POST['v1']);
$p1 = ($_POST['p1']);
$v2 = ($_POST['v2']);
$p2 = ($_POST['p2']);

// Security
if ($v1 === '') {
    $response = [
        'response' => 100,
        'success' => false,
        'message' => "v1 is required."
    ];
    goto end;
}

if ($v1 !== '?' && !is_numeric($v1)) {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "v1 must be a number or '?'."
    ];
    goto end;
}

if ($p1 === '') {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "p1 is required."
    ];
    goto end;
}

if ($p1 !== '?' && !is_numeric($p1)) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "p1 must be a number or '?'."
    ];
    goto end;
}

if ($v2 === '') {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "v2 is required."
    ];
    goto end;
}

if ($v2 !== '?' && !is_numeric($v2)) {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "v2 must be a number or '?'."
    ];
    goto end;
}

if ($p2 === '') {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "p2 is required."
    ];
    goto end;
}

if ($p2 !== '?' && !is_numeric($p2)) {
    $response = [
        'response' => 108,
        'success' => false,
        'message' => "p2 must be a number or '?'."
    ];
    goto end;
}


// Confirmation of '?'
$unknowns = 0;
if ($v1 === '?') $unknowns++;
if ($p1 === '?') $unknowns++;
if ($v2 === '?') $unknowns++;
if ($p2 === '?') $unknowns++;

if ($unknowns !== 1) {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "Only one value must be '?'."
    ];
    goto end;
}

// Calculate P1 * V1 = P2 * V2
if ($v1 === '?') {
    if ($p1 == 0) {
        $response = [
            'response' => 109,
            'success' => false,
            'message' => 'Division by zero not allowed.',
        ];
        goto end;
    }
    $v1 = round(($p2 * $v2) / $p1, 3);
    $missing = 'v1';
    $value = $v1;

} elseif ($p1 === '?') {
    if ($v1 == 0) {
        $response = [
            'response' => 110,
            'success' => false,
            'message' => 'Division by zero not allowed.',
        ];
        goto end;
    }
    $p1 = round(($p2 * $v2) / $v1, 3);
    $missing = 'p1';
    $value = $p1;

} elseif ($v2 === '?') {
    if ($p2 == 0) {
        $response = [
            'response' => 111,
            'success' => false,
            'message' => 'Division by zero not allowed.',
        ];
        goto end;
    }
    $v2 = round(($p1 * $v1) / $p2, 3);
    $missing = 'v2';
    $value = $v2;

} elseif ($p2 === '?') {
    if ($v2 == 0) {
        $response = [
            'response' => 112,
            'success' => false,
            'message' => 'Division by zero not allowed.',
        ];
        goto end;
    }
    $p2 = round(($p1 * $v1) / $v2, 3);
    $missing = 'p2';
    $value = $p2;
}

$response = [
    'response' => 200,
    'success' => true,
    'missing' => $missing,
    'value' => $value,
    'description' => "The missing value ($missing) is $value using Boyle's Law (P1 * V1 = P2 * V2)"
];
end:
echo json_encode($response);
?>
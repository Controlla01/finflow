<?php require_once 'config/connection.php'; ?>

<?php

$SDT101 = ($_POST['SDT101']);
$MAD102 = ($_POST['MAD102']);
$WAD104 = ($_POST['WAD104']);
$SDA103 = ($_POST['SDA103']);
$AGD106 = ($_POST['AGD106']);
$NS105 = ($_POST['NS105']);

// VALIDATIONS

if ($SDT101 === "") {
    $response = [
        'response' => 100,
        'success' => false,
        'message' => "SDT101 REQUIRED! Provide SDT101 and try again.",
    ];
    goto end;
}

if (!is_numeric($SDT101)) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "INVALID SDT101! Enter a numeric value.",
    ];
    goto end;
}

if ($SDT101 < 0) {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "INVALID SDT101! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($SDT101 > 100) {
    $response = [
        'response' => 108,
        'success' => false,
        'message' => "INVALID SDT101! Enter a value less than or equal to 100.",
    ];
    goto end;
}

if ($MAD102 === "") {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "MAD102 REQUIRED! Provide MAD102 and try again.",
    ];
    goto end;
}

if (!is_numeric($MAD102)) {
    $response = [
        'response' => 109,
        'success' => false,
        'message' => "INVALID MAD102! Enter a numeric value.",
    ];
    goto end;
}

if ($MAD102 < 0) {
    $response = [
        'response' => 110,
        'success' => false,
        'message' => "INVALID MAD102! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($MAD102 > 100) {
    $response = [
        'response' => 111,
        'success' => false,
        'message' => "INVALID MAD102! Enter a value less than or equal to 100.",
    ];
    goto end;
}

if ($SDA103 === "") {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "SDA103 REQUIRED! Provide SDA103 and try again.",
    ];
    goto end;
}

if (!is_numeric($SDA103)) {
    $response = [
        'response' => 112,
        'success' => false,
        'message' => "INVALID SDA103! Enter a numeric value.",
    ];
    goto end;
}

if ($SDA103 < 0) {
    $response = [
        'response' => 113,
        'success' => false,
        'message' => "INVALID SDA103! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($SDA103 > 100) {
    $response = [
        'response' => 114,
        'success' => false,
        'message' => "INVALID SDA103! Enter a value less than or equal to 100.",
    ];
    goto end;
}

if ($WAD104 === "") {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "WAD104 REQUIRED! Provide WAD104 and try again.",
    ];
    goto end;
}

if (!is_numeric($WAD104)) {
    $response = [
        'response' => 115,
        'success' => false,
        'message' => "INVALID WAD104! Enter a numeric value.",
    ];
    goto end;
}

if ($WAD104 < 0) {
    $response = [
        'response' => 116,
        'success' => false,
        'message' => "INVALID WAD104! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($WAD104 > 100) {
    $response = [
        'response' => 117,
        'success' => false,
        'message' => "INVALID WAD104! Enter a value less than or equal to 100.",
    ];
    goto end;
}

if ($NS105 === "") {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "NS105 REQUIRED! Provide NS105 and try again.",
    ];
    goto end;
}

if (!is_numeric($NS105)) {
    $response = [
        'response' => 118,
        'success' => false,
        'message' => "INVALID NS105! Enter a numeric value.",
    ];
    goto end;
}

if ($NS105 < 0) {
    $response = [
        'response' => 119,
        'success' => false,
        'message' => "INVALID NS105! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($NS105 > 100) {
    $response = [
        'response' => 120,
        'success' => false,
        'message' => "INVALID NS105! Enter a value less than or equal to 100.",
    ];
    goto end;
}

if ($AGD106 === "") {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "AGD106 REQUIRED! Provide AGD106 and try again.",
    ];
    goto end;
}

if (!is_numeric($AGD106)) {
    $response = [
        'response' => 121,
        'success' => false,
        'message' => "INVALID AGD106! Enter a numeric value.",
    ];
    goto end;
}

if ($AGD106 < 0) {
    $response = [
        'response' => 122,
        'success' => false,
        'message' => "INVALID AGD106! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($AGD106 > 100) {
    $response = [
        'response' => 123,
        'success' => false,
        'message' => "INVALID AGD106! Enter a value less than or equal to 100.",
    ];
    goto end;
}

// GRADE POINT CALCULATION

if ($SDT101 >= 80) $Gradepoint1 = 4 * 4;
elseif ($SDT101 >= 70) $Gradepoint1 = 4 * 3.5;
elseif ($SDT101 >= 60) $Gradepoint1 = 4 * 3;
elseif ($SDT101 >= 50) $Gradepoint1 = 4 * 2.5;
elseif ($SDT101 >= 40) $Gradepoint1 = 4 * 2;
else $Gradepoint1 = 4 * 0;

if ($MAD102 >= 80) $Gradepoint2 = 4 * 4;
elseif ($MAD102 >= 70) $Gradepoint2 = 4 * 3.5;
elseif ($MAD102 >= 60) $Gradepoint2 = 4 * 3;
elseif ($MAD102 >= 50) $Gradepoint2 = 4 * 2.5;
elseif ($MAD102 >= 40) $Gradepoint2 = 4 * 2;
else $Gradepoint2 = 4 * 0;

if ($SDA103 >= 80) $Gradepoint3 = 5 * 4;
elseif ($SDA103 >= 70) $Gradepoint3 = 5 * 3.5;
elseif ($SDA103 >= 60) $Gradepoint3 = 5 * 3;
elseif ($SDA103 >= 50) $Gradepoint3 = 5 * 2.5;
elseif ($SDA103 >= 40) $Gradepoint3 = 5 * 2;
else $Gradepoint3 = 5 * 0;

if ($WAD104 >= 80) $Gradepoint4 = 4 * 4;
elseif ($WAD104 >= 70) $Gradepoint4 = 4 * 3.5;
elseif ($WAD104 >= 60) $Gradepoint4 = 4 * 3;
elseif ($WAD104 >= 50) $Gradepoint4 = 4 * 2.5;
elseif ($WAD104 >= 40) $Gradepoint4 = 4 * 2;
else $Gradepoint4 = 4 * 0;

if ($NS105 >= 80) $Gradepoint5 = 4 * 4;
elseif ($NS105 >= 70) $Gradepoint5 = 4 * 3.5;
elseif ($NS105 >= 60) $Gradepoint5 = 4 * 3;
elseif ($NS105 >= 50) $Gradepoint5 = 4 * 2.5;
elseif ($NS105 >= 40) $Gradepoint5 = 4 * 2;
else $Gradepoint5 = 4 * 0;

if ($AGD106 >= 80) $Gradepoint6 = 4 * 4;
elseif ($AGD106 >= 70) $Gradepoint6 = 4 * 3.5;
elseif ($AGD106 >= 60) $Gradepoint6 = 4 * 3;
elseif ($AGD106 >= 50) $Gradepoint6 = 4 * 2.5;
elseif ($AGD106 >= 40) $Gradepoint6 = 4 * 2;
else $Gradepoint6 = 4 * 0;

$TGP = $Gradepoint1 + $Gradepoint2 + $Gradepoint3 + $Gradepoint4 + $Gradepoint5 + $Gradepoint6;
$TCU = 25;
$GPA = round($TGP / $TCU, 2);

$response = [
    'response' => 203,
    'success' => true,
    'totalGradePoint' => $TGP,
    'totalCourseUnit' => $TCU,
    'gradePointAverage' => round($GPA, 2),
    'message' => "The GRADE POINT AVERAGE is " . round($GPA, 2),
];


end:
echo json_encode($response);

?>

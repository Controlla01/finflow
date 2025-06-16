<?php require_once 'config/connection.php'; ?>

<?php

$DBMS201 = ($_POST['DBMS201']);
$UIUX202 = ($_POST['UIUX202']);
$AI204 = ($_POST['AI204']);
$SQT205 = ($_POST['SQT205']);
$AA206 = ($_POST['AA206']);
$DEVOP207 = ($_POST['DEVOP207']);

// VALIDATIONS

if ($DBMS201 === "") {
    $response = [
        'response' => 100,
        'success' => false,
        'message' => "DBMS201 REQUIRED! Provide DBMS201 and try again.",
    ];
    goto end;
}

if (!is_numeric($DBMS201)) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "INVALID DBMS201! Enter a numeric value.",
    ];
    goto end;
}

if ($DBMS201 < 0) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "INVALID DBMS201! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($DBMS201 > 100) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "INVALID DBMS201! Enter a value less than or equal to 100.",
    ];
    goto end;
}

if ($UIUX202 === "") {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "UIUX202 REQUIRED! Provide UIUX202 and try again.",
    ];
    goto end;
}

if (!is_numeric($UIUX202)) {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "INVALID UIUX202! Enter a numeric value.",
    ];
    goto end;
}

if ($UIUX202 < 0) {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "INVALID UIUX202! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($UIUX202 > 100) {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "INVALID UIUX202! Enter a value less than or equal to 100.",
    ];
    goto end;
}

if ($AI204 === "") {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "AI204 REQUIRED! Provide AI204 and try again.",
    ];
    goto end;
}

if (!is_numeric($AI204)) {
    $response = [
        'response' => 108,
        'success' => false,
        'message' => "INVALID AI204! Enter a numeric value.",
    ];
    goto end;
}

if ($AI204 < 0) {
    $response = [
        'response' => 108,
        'success' => false,
        'message' => "INVALID AI204! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($AI204 > 100) {
    $response = [
        'response' => 108,
        'success' => false,
        'message' => "INVALID AI204! Enter a value less than or equal to 100.",
    ];
    goto end;
}

if ($SQT205 === "") {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "SQT205 REQUIRED! Provide SQT205 and try again.",
    ];
    goto end;
}

if (!is_numeric($SQT205)) {
    $response = [
        'response' => 109,
        'success' => false,
        'message' => "INVALID SQT205! Enter a numeric value.",
    ];
    goto end;
}

if ($SQT205 < 0) {
    $response = [
        'response' => 109,
        'success' => false,
        'message' => "INVALID SQT205! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($SQT205 > 100) {
    $response = [
        'response' => 109,
        'success' => false,
        'message' => "INVALID SQT205! Enter a value less than or equal to 100.",
    ];
    goto end;
}

if ($AA206 === "") {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "AA206 REQUIRED! Provide AA206 and try again.",
    ];
    goto end;
}

if (!is_numeric($AA206)) {
    $response = [
        'response' => 110,
        'success' => false,
        'message' => "INVALID AA206! Enter a numeric value.",
    ];
    goto end;
}

if ($AA206 < 0) {
    $response = [
        'response' => 110,
        'success' => false,
        'message' => "INVALID AA206! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($AA206 > 100) {
    $response = [
        'response' => 110,
        'success' => false,
        'message' => "INVALID AA206! Enter a value less than or equal to 100.",
    ];
    goto end;
}

if ($DEVOP207 === "") {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "DEVOP207 REQUIRED! Provide DEVOP207 and try again.",
    ];
    goto end;
}

if (!is_numeric($DEVOP207)) {
    $response = [
        'response' => 111,
        'success' => false,
        'message' => "INVALID DEVOP207! Enter a numeric value.",
    ];
    goto end;
}

if ($DEVOP207 < 0) {
    $response = [
        'response' => 111,
        'success' => false,
        'message' => "INVALID DEVOP207! Enter a value greater than or equal to 0.",
    ];
    goto end;
}

if ($DEVOP207 > 100) {
    $response = [
        'response' => 111,
        'success' => false,
        'message' => "INVALID DEVOP207! Enter a value less than or equal to 100.",
    ];
    goto end;
}

// GRADE POINT CALCULATIONS

if ($DBMS201 >= 80) $Gradepoint1 = 3 * 4;
elseif ($DBMS201 >= 70) $Gradepoint1 = 3 * 3.5;
elseif ($DBMS201 >= 60) $Gradepoint1 = 3 * 3;
elseif ($DBMS201 >= 50) $Gradepoint1 = 3 * 2.5;
elseif ($DBMS201 >= 40) $Gradepoint1 = 3 * 2;
else $Gradepoint1 = 3 * 0;

if ($UIUX202 >= 80) $Gradepoint2 = 2 * 4;
elseif ($UIUX202 >= 70) $Gradepoint2 = 2 * 3.5;
elseif ($UIUX202 >= 60) $Gradepoint2 = 2 * 3;
elseif ($UIUX202 >= 50) $Gradepoint2 = 2 * 2.5;
elseif ($UIUX202 >= 40) $Gradepoint2 = 2 * 2;
else $Gradepoint2 = 2 * 0;

if ($AI204 >= 80) $Gradepoint3 = 3 * 4;
elseif ($AI204 >= 70) $Gradepoint3 = 3 * 3.5;
elseif ($AI204 >= 60) $Gradepoint3 = 3 * 3;
elseif ($AI204 >= 50) $Gradepoint3 = 3 * 2.5;
elseif ($AI204 >= 40) $Gradepoint3 = 3 * 2;
else $Gradepoint3 = 3 * 0;

if ($SQT205 >= 80) $Gradepoint4 = 2 * 4;
elseif ($SQT205 >= 70) $Gradepoint4 = 2 * 3.5;
elseif ($SQT205 >= 60) $Gradepoint4 = 2 * 3;
elseif ($SQT205 >= 50) $Gradepoint4 = 2 * 2.5;
elseif ($SQT205 >= 40) $Gradepoint4 = 2 * 2;
else $Gradepoint4 = 2 * 0;

if ($AA206 >= 80) $Gradepoint5 = 3 * 4;
elseif ($AA206 >= 70) $Gradepoint5 = 3 * 3.5;
elseif ($AA206 >= 60) $Gradepoint5 = 3 * 3;
elseif ($AA206 >= 50) $Gradepoint5 = 3 * 2.5;
elseif ($AA206 >= 40) $Gradepoint5 = 3 * 2;
else $Gradepoint5 = 3 * 0;

if ($DEVOP207 >= 80) $Gradepoint6 = 3 * 4;
elseif ($DEVOP207 >= 70) $Gradepoint6 = 3 * 3.5;
elseif ($DEVOP207 >= 60) $Gradepoint6 = 3 * 3;
elseif ($DEVOP207 >= 50) $Gradepoint6 = 3 * 2.5;
elseif ($DEVOP207 >= 40) $Gradepoint6 = 3 * 2;
else $Gradepoint6 = 3 * 0;


$TGP = $Gradepoint1 + $Gradepoint2 + $Gradepoint3 + $Gradepoint4 + $Gradepoint5 + $Gradepoint6;
$TCU = 16;
$GPA = $TGP / $TCU;

$response = [
    'response' => 203,
    'success' => true,
    'totalGradePoint' => $TGP,
    'totalCourseUnit' => $TCU,
    'gradePointAverage' => $GPA,
    'message' => "The GRADE POINT AVERAGE is " . round($GPA, 2),
];

end:
echo json_encode($response);
?>

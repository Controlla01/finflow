<?php require_once 'config/connection.php'; ?>

<?php

$birthDay = trim($_POST['birthDay']);
$birthMonth = trim($_POST['birthMonth']);
$birthYear = trim($_POST['birthYear']);

$currentYear = date("Y");
$currentMonth = date("m");
$currentDay = date("d");

if ($birthDay === "") {
    $response = [
        'response' => 100,
        'success' => false,
        'message' => "DAY IS REQUIRED! Provide day of birth."
    ];
    goto end;
}

if ($birthMonth === "") {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "MONTH IS REQUIRED! Provide month of birth."
    ];
    goto end;
}

if ($birthYear === "") {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "YEAR IS REQUIRED! Provide year of birth."
    ];
    goto end;
}

if (!ctype_digit($birthDay)) {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "INVALID DAY! Only numbers allowed."
    ];
    goto end;
}

if (!ctype_digit($birthMonth)) {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "INVALID MONTH! Only numbers allowed."
    ];
    goto end;
}

if (!ctype_digit($birthYear)) {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "INVALID YEAR! Only numbers allowed."
    ];
    goto end;
}

$birthDay = intval($birthDay);
$birthMonth = intval($birthMonth);
$birthYear = intval($birthYear);

if ($birthDay < 1) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "INVALID DAY! Day cannot be less than 1."
    ];
    goto end;
}

if ($birthMonth < 1) {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "INVALID MONTH! Month cannot be less than 1."
    ];
    goto end;
}

if ($birthMonth > 12) {
    $response = [
        'response' => 108,
        'success' => false,
        'message' => "INVALID MONTH! Month cannot be greater than 12."
    ];
    goto end;
}

$daysInBirthMonth = cal_days_in_month(CAL_GREGORIAN, $birthMonth, $birthYear);

if ($birthDay > $daysInBirthMonth) {
    $response = [
        'response' => 109,
        'success' => false,
        'message' => "INVALID DAY! Month $birthMonth has only $daysInBirthMonth days."
    ];
    goto end;
}

if ($birthYear < 1900) {
    $response = [
        'response' => 110,
        'success' => false,
        'message' => "INVALID YEAR! Year cannot be before 1900."
    ];
    goto end;
}

if ($birthYear > $currentYear) {
    $response = [
        'response' => 111,
        'success' => false,
        'message' => "INVALID YEAR! Year cannot be in the future."
    ];
    goto end;
}

$ageYear = $currentYear - $birthYear;

if ($currentMonth >= $birthMonth) {
    $ageMonth = $currentMonth - $birthMonth;
} else {
    $ageYear -= 1;
    $ageMonth = 12 + $currentMonth - $birthMonth;
}

if ($currentDay >= $birthDay) {
    $ageDay = $currentDay - $birthDay;
} else {
    $ageMonth -= 1;
    $ageDay = $currentDay + cal_days_in_month(CAL_GREGORIAN, $birthMonth, $birthYear) - $birthDay;

    if ($ageMonth < 0) {
        $ageMonth = 11;
        $ageYear -= 1;
    }
}

if ($ageYear < 0) {
    $response = [
        'response' => 112,
        'success' => false,
        'message' => "INVALID DATE! Date cannot be in the future."
    ];
    goto end;
}

$response = [
    'response' => 200,
    'success' => true,
    'ageYear' => $ageYear,
    'ageMonth' => $ageMonth,
    'ageDay' => $ageDay,
    'message' => "You are $ageYear year(s), $ageMonth month(s), and $ageDay day(s) old."
];

end:
echo json_encode($response);
?>

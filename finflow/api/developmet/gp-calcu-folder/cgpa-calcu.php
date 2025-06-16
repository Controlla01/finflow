<?php require_once 'config/connection.php'; ?>

<?php

// FIRST SEMESTER COURSES
$HTML101 = trim($_POST['HTML101']);
$CSS102 = trim($_POST['CSS102']);
$JS103 = trim($_POST['JS103']);
$PHP104 = trim($_POST['PHP104']);
$MYSQL105 = trim($_POST['MYSQL105']);
$UIUX106 = trim($_POST['UIUX106']);

// SECOND SEMESTER COURSES
$SDT101 = trim($_POST['SDT101']);
$MAD102 = trim($_POST['MAD102']);
$SDA103 = trim($_POST['SDA103']);
$WAD104 = trim($_POST['WAD104']);
$NS105 = trim($_POST['NS105']);
$AGD106 = trim($_POST['AGD106']);

// SECURITY + VALIDATION — FIRST SEMESTER
if($HTML101 === ""){
    $response = ['response'=>100, 'success'=>false, 'message'=>" HTML101 REQUIRED! Provide HTML101 and try again."]; goto end;
}
if(!is_numeric($HTML101) || $HTML101 < 0 || $HTML101 > 100){
    $response = ['response'=>200, 'success'=>false, 'message'=>"INVALID HTML101! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

if($CSS102 === ""){
    $response = ['response'=>101, 'success'=>false, 'message'=>" CSS102 REQUIRED! Provide CSS102 and try again."]; goto end;
}
if(!is_numeric($CSS102) || $CSS102 < 0 || $CSS102 > 100){
    $response = ['response'=>201, 'success'=>false, 'message'=>"INVALID CSS102! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

if($JS103 === ""){
    $response = ['response'=>102, 'success'=>false, 'message'=>" JS103 REQUIRED! Provide JS103 and try again."]; goto end;
}
if(!is_numeric($JS103) || $JS103 < 0 || $JS103 > 100){
    $response = ['response'=>202, 'success'=>false, 'message'=>"INVALID JS103! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

if($PHP104 === ""){
    $response = ['response'=>103, 'success'=>false, 'message'=>" PHP104 REQUIRED! Provide PHP104 and try again."]; goto end;
}
if(!is_numeric($PHP104) || $PHP104 < 0 || $PHP104 > 100){
    $response = ['response'=>203, 'success'=>false, 'message'=>"INVALID PHP104! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

if($MYSQL105 === ""){
    $response = ['response'=>104, 'success'=>false, 'message'=>" MYSQL105 REQUIRED! Provide MYSQL105 and try again."]; goto end;
}
if(!is_numeric($MYSQL105) || $MYSQL105 < 0 || $MYSQL105 > 100){
    $response = ['response'=>204, 'success'=>false, 'message'=>"INVALID MYSQL105! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

if($UIUX106 === ""){
    $response = ['response'=>105, 'success'=>false, 'message'=>" UIUX106 REQUIRED! Provide UIUX106 and try again."]; goto end;
}
if(!is_numeric($UIUX106) || $UIUX106 < 0 || $UIUX106 > 100){
    $response = ['response'=>205, 'success'=>false, 'message'=>"INVALID UIUX106! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

// SECURITY + VALIDATION — SECOND SEMESTER
if($SDT101 === ""){
    $response = ['response'=>106, 'success'=>false, 'message'=>" SDT101 REQUIRED! Provide SDT101 and try again."]; goto end;
}
if(!is_numeric($SDT101) || $SDT101 < 0 || $SDT101 > 100){
    $response = ['response'=>206, 'success'=>false, 'message'=>"INVALID SDT101! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

if($MAD102 === ""){
    $response = ['response'=>107, 'success'=>false, 'message'=>" MAD102 REQUIRED! Provide MAD102 and try again."]; goto end;
}
if(!is_numeric($MAD102) || $MAD102 < 0 || $MAD102 > 100){
    $response = ['response'=>207, 'success'=>false, 'message'=>"INVALID MAD102! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

if($SDA103 === ""){
    $response = ['response'=>108, 'success'=>false, 'message'=>" SDA103 REQUIRED! Provide SDA103 and try again."]; goto end;
}
if(!is_numeric($SDA103) || $SDA103 < 0 || $SDA103 > 100){
    $response = ['response'=>208, 'success'=>false, 'message'=>"INVALID SDA103! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

if($WAD104 === ""){
    $response = ['response'=>109, 'success'=>false, 'message'=>" WAD104 REQUIRED! Provide WAD104 and try again."]; goto end;
}
if(!is_numeric($WAD104) || $WAD104 < 0 || $WAD104 > 100){
    $response = ['response'=>209, 'success'=>false, 'message'=>"INVALID WAD104! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

if($NS105 === ""){
    $response = ['response'=>110, 'success'=>false, 'message'=>" NS105 REQUIRED! Provide NS105 and try again."]; goto end;
}
if(!is_numeric($NS105) || $NS105 < 0 || $NS105 > 100){
    $response = ['response'=>210, 'success'=>false, 'message'=>"INVALID NS105! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

if($AGD106 === ""){
    $response = ['response'=>111, 'success'=>false, 'message'=>" AGD106 REQUIRED! Provide AGD106 and try again."]; goto end;
}
if(!is_numeric($AGD106) || $AGD106 < 0 || $AGD106 > 100){
    $response = ['response'=>211, 'success'=>false, 'message'=>"INVALID AGD106! ENTER ONLY NUMERIC VALUE between 0 and 100."]; goto end;
}

// MANUAL GPA CALCULATION — FIRST SEMESTER
if($HTML101 >= 80){ $gp1 = 2 * 4; }
elseif($HTML101 >= 70){ $gp1 = 2 * 3.5; }
elseif($HTML101 >= 60){ $gp1 = 2 * 3; }
elseif($HTML101 >= 50){ $gp1 = 2 * 2.5; }
elseif($HTML101 >= 40){ $gp1 = 2 * 2; }
else{ $gp1 = 2 * 0; }

if($CSS102 >= 80){ $gp2 = 3 * 4; }
elseif($CSS102 >= 70){ $gp2 = 3 * 3.5; }
elseif($CSS102 >= 60){ $gp2 = 3 * 3; }
elseif($CSS102 >= 50){ $gp2 = 3 * 2.5; }
elseif($CSS102 >= 40){ $gp2 = 3 * 2; }
else{ $gp2 = 3 * 0; }

if($JS103 >= 80){ $gp3 = 2 * 4; }
elseif($JS103 >= 70){ $gp3 = 2 * 3.5; }
elseif($JS103 >= 60){ $gp3 = 2 * 3; }
elseif($JS103 >= 50){ $gp3 = 2 * 2.5; }
elseif($JS103 >= 40){ $gp3 = 2 * 2; }
else{ $gp3 = 2 * 0; }

if($PHP104 >= 80){ $gp4 = 4 * 4; }
elseif($PHP104 >= 70){ $gp4 = 4 * 3.5; }
elseif($PHP104 >= 60){ $gp4 = 4 * 3; }
elseif($PHP104 >= 50){ $gp4 = 4 * 2.5; }
elseif($PHP104 >= 40){ $gp4 = 4 * 2; }
else{ $gp4 = 4 * 0; }

if($MYSQL105 >= 80){ $gp5 = 4 * 4; }
elseif($MYSQL105 >= 70){ $gp5 = 4 * 3.5; }
elseif($MYSQL105 >= 60){ $gp5 = 4 * 3; }
elseif($MYSQL105 >= 50){ $gp5 = 4 * 2.5; }
elseif($MYSQL105 >= 40){ $gp5 = 4 * 2; }
else{ $gp5 = 4 * 0; }

if($UIUX106 >= 80){ $gp6 = 2 * 4; }
elseif($UIUX106 >= 70){ $gp6 = 2 * 3.5; }
elseif($UIUX106 >= 60){ $gp6 = 2 * 3; }
elseif($UIUX106 >= 50){ $gp6 = 2 * 2.5; }
elseif($UIUX106 >= 40){ $gp6 = 2 * 2; }
else{ $gp6 = 2 * 0; }

$TGP1 = $gp1 + $gp2 + $gp3 + $gp4 + $gp5 + $gp6;
$TCU1 = 17;
$GPA1 = $TGP1 / $TCU1;

// MANUAL GPA CALCULATION — SECOND SEMESTER
if($SDT101 >= 80){ $gp7 = 4 * 4; }
elseif($SDT101 >= 70){ $gp7 = 4 * 3.5; }
elseif($SDT101 >= 60){ $gp7 = 4 * 3; }
elseif($SDT101 >= 50){ $gp7 = 4 * 2.5; }
elseif($SDT101 >= 40){ $gp7 = 4 * 2; }
else{ $gp7 = 4 * 0; }

if($MAD102 >= 80){ $gp8 = 4 * 4; }
elseif($MAD102 >= 70){ $gp8 = 4 * 3.5; }
elseif($MAD102 >= 60){ $gp8 = 4 * 3; }
elseif($MAD102 >= 50){ $gp8 = 4 * 2.5; }
elseif($MAD102 >= 40){ $gp8 = 4 * 2; }
else{ $gp8 = 4 * 0; }

if($SDA103 >= 80){ $gp9 = 5 * 4; }
elseif($SDA103 >= 70){ $gp9 = 5 * 3.5; }
elseif($SDA103 >= 60){ $gp9 = 5 * 3; }
elseif($SDA103 >= 50){ $gp9 = 5 * 2.5; }
elseif($SDA103 >= 40){ $gp9 = 5 * 2; }
else{ $gp9 = 5 * 0; }

if($WAD104 >= 80){ $gp10 = 4 * 4; }
elseif($WAD104 >= 70){ $gp10 = 4 * 3.5; }
elseif($WAD104 >= 60){ $gp10 = 4 * 3; }
elseif($WAD104 >= 50){ $gp10 = 4 * 2.5; }
elseif($WAD104 >= 40){ $gp10 = 4 * 2; }
else{ $gp10 = 4 * 0; }

if($NS105 >= 80){ $gp11 = 4 * 4; }
elseif($NS105 >= 70){ $gp11 = 4 * 3.5; }
elseif($NS105 >= 60){ $gp11 = 4 * 3; }
elseif($NS105 >= 50){ $gp11 = 4 * 2.5; }
elseif($NS105 >= 40){ $gp11 = 4 * 2; }
else{ $gp11 = 4 * 0; }

if($AGD106 >= 80){ $gp12 = 4 * 4; }
elseif($AGD106 >= 70){ $gp12 = 4 * 3.5; }
elseif($AGD106 >= 60){ $gp12 = 4 * 3; }
elseif($AGD106 >= 50){ $gp12 = 4 * 2.5; }
elseif($AGD106 >= 40){ $gp12 = 4 * 2; }
else{ $gp12 = 4 * 0; }

$TGP2 = $gp7 + $gp8 + $gp9 + $gp10 + $gp11 + $gp12;
$TCU2 = 25;
$GPA2 = $TGP2 / $TCU2;

// CGPA CALCULATION
$CGPA = ($TGP1 + $TGP2) / ($TCU1 + $TCU2);

// CGPA CLASSIFICATION
if($CGPA >= 3.5){ $class = "DISTINCTION"; }
elseif($CGPA >= 3.0){ $class = "UPPER CREDIT"; }
elseif($CGPA >= 2.5){ $class = "LOWER CREDIT"; }
elseif($CGPA >= 2.0){ $class = "PASS"; }
else{ $class = "FAIL"; }

$response = [
    'response' => 212,
    'success' => true,
    'GPA_FIRST' => round($GPA1,2),
    'GPA_SECOND' => round($GPA2,2),
    'CGPA' => round($CGPA,2),
    'classification' => $class,
    'message' => "Your CGPA is " . round($CGPA,2) . " - $class",
];

end:
echo json_encode($response);
?>

<?php require_once 'config/connection.php'; ?>
<?php


$firstNumber = trim($_POST['firstNumber']);
$secondNumber = trim($_POST['secondNumber']);
$operator = trim($_POST['operator']);

// Secu

if ($firstNumber === '') {
    $response = [
        'response' => 100,
        'success' => false,
        'message' => "ALL FIELDS REQUIRED! Provide value for firstNumber."
    ];
    goto end;
}

if (!is_numeric($firstNumber)) {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "INVALID INPUT! firstNumber must be a number."
    ];
    goto end;
}

if ($secondNumber === '') {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "ALL FIELDS REQUIRED! Provide value for secondNumber."
    ];
    goto end;
}

if (!is_numeric($secondNumber)) {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "INVALID INPUT! secondNumber must be a number."
    ];
    goto end;
}

if ($operator === '') {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "ALL FIELDS REQUIRED! Select an operator."
    ];
    goto end;
}

$validOperator=["+", "-", "x", "/"];
if (!in_array($operator, $validOperator)) {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "INVALID OPERATOR! Use: add, subtract, multiply, divide."
    ];
    goto end;
}


/// Calcu
if ($operator === '+') {
    $result = $firstNumber + $secondNumber;
    $expression = "$firstNumber + $secondNumber = $result";
} elseif ($operator === '-') {
    $result = $firstNumber - $secondNumber;
    $expression = "$firstNumber - $secondNumber = $result";
} elseif ($operator === 'x') {
    $result = $firstNumber * $secondNumber;
    $expression = "$firstNumber * $secondNumber = $result";
} elseif ($operator === '/') {
    if ($secondNumber == 0) {
        $response = [
            'response' => 105,
            'success' => false,
            'message' => "DIVISION ERROR! Cannot divide by zero."
        ];
        goto end;
    }
    $result = $firstNumber / $secondNumber;
    $expression = "$firstNumber / $secondNumber = $result";
}

$response = [
    'response' => 200,
    'success' => true,
    'firstNumber' => $firstNumber,
    'secondNumber' => $secondNumber,
    'operator' => $operator,
    'result' =>($result),
    'message' => "Result: $expression"
];

end:
echo json_encode($response);
?>
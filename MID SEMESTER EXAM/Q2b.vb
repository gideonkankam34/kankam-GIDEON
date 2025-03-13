<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Contact Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            text-align: center;
            margin: 0;
            padding: 0;
        }
        .contact-form {
            width: 50%;
            margin: 50px auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .contact-form h2 {
            margin-bottom: 20px;
        }
        .contact-form label {
            display: block;
            margin-bottom: 10px;
            font-weight: bold;
        }
        .contact-form input {
            width: 100%;
            padding: 10px;
            margin-bottom: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <div class="contact-form">
        <h2>CONTACT PAGE</h2>
        <form>
            <label for="name">Name:</label>
            <input type="text" id="name" name="name">
            
            <label for="phone">Phone Number:</label>
            <input type="text" id="phone" name="phone">
            
            <label for="email">Email Address:</label>
            <input type="email" id="email" name="email">
            
            <label for="program">Program:</label>
            <input type="text" id="program" name="program">
            
            <label for="level">Level:</label>
            <input type="text" id="level" name="level">
            
            <label for="index">Index Number:</label>
            <input type="text" id="index" name="index">
        </form>
    </div>
</body>
</html>

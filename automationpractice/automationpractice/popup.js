var nodemailer = require('nodemailer');
var nodemailer = require('nodemailer');

var transporter = nodemailer.createTransport({
    service: 'gmail',
    auth: {
        user: 'ajay13596@gmail.com',
        pass: 'Kishore123'
    }
});

var mailOptions = {
    from: 'ajay13596@gmail.com',
    to: 'ajay13596@gmail.com',
    subject: 'Sending Email using Node.js',
    text: 'That was easy!'
};

transporter.sendMail(mailOptions, function (error, info) {
    if (error) {
        console.log(error);
    } else {
        console.log('Email sent: ' + info.response);
    }
});
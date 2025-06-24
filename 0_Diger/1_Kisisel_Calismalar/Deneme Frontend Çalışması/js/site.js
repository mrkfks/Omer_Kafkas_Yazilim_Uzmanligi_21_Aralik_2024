$(document).ready(function() {
  $('button').click(function() {
    alert('buton aktif');
  });
  $('#submit').click(function() {
    alert('Button Call Submit');
  });
  $('.form-label').click(function(){
    alert('Form label click');
  });
  $('div.bg-danger').click(function(){
    alert('dive tıklandı');
  });
  $('div#box').click(function(){
    $(this).toggleClass('bg-danger')
  })
  
  $('#loginForm').submit(function (e) { 
    e.preventDefault();
    const email = $('#email').val()
    const password = $('#password').val()
    const remember =$('#remember').is(':checked');
    const city = $('#city').val()
    console.log(email, password, remember, city)
    
  });

  $('#email').change(function (e) { 
    console.log('değişti')
  });

  $('#email').keyup(function (e) { 
    console.log('keyup call')
  });

}) 
/**
 * Created by glua on 4/27/18.
 */

const receiverToggle = document.getElementById('id_same_billing_shipping');
const receiver = document.getElementById('receiver');
const selfPick = document.querySelector('#selfpick');
const courierPick = document.querySelector('#courier');
const selfpickBlock = document.querySelector('.selfpick');
const courierBlock = document.querySelector('.courier');

const bName = document.getElementById('id_billing_detail_last_first_name');
const bEmail = document.getElementById('id_billing_detail_email');
const bPhone = document.getElementById('id_billing_detail_phone');
const owner = document.getElementById('id_same_billing_shipping');
const rName = document.getElementById('id_shipping_detail_last_first_name');
const rPhone = document.getElementById('id_shipping_detail_phone');

if(bName !== null) {
    bName.addEventListener('blur', validateName);
}
if(bEmail !== null) {
    bEmail.addEventListener('blur', validateEmail);
}
if(bPhone !== null) {
    bPhone.addEventListener('blur', validatePhone);
}
if(rName !== null) {
    rName.addEventListener('blur', validateRName);
}

// Validate Name field
function validateName() {
    if(bName.value.length < 3 || bName.value.length > 36) {
        bName.closest('.ds-input').classList.add('ds-input--error');
    } else {
        bName.closest('.ds-input').classList.remove('ds-input--error');
    }
}

// Validate email
function validateEmail() {
    const re = /^([a-zA-z0-9_\-\.]+)@([a-zA-z0-9_\-\.]+)\.([a-zA-Z]{2,10})$/;
    if(!re.test(bEmail.value)) {
        bEmail.closest('.ds-input').classList.add('ds-input--error');
    } else {
        bEmail.closest('.ds-input').classList.remove('ds-input--error');
    }
};

function validatePhone() {
    console.log(bPhone.value.length)
};

// Validate Recipient
function validateRName() {
    if(rName.value.length < 3 || rName.value.length > 36) {
        rName.closest('.ds-input').classList.add('ds-input--error');
    } else {
        rName.closest('.ds-input').classList.remove('ds-input--error');
    }
}
//$.mask.definitions['c']="/^[0-9]{1,3}$/";
//$('#id_billing_detail_phone').mask("(99) 999-99-99").attr({'placeholder':'+380 (__) ___ __ __'});

if(owner !== null) {
    owner.checked = false;
}
if(rName !== null) {
    rName.required = true;
}
if(rPhone !== null) {
    rPhone.required = false;
}

if(receiverToggle !== null) {
    receiverToggle.addEventListener('click', function () {
        if (receiverToggle.checked) {
            receiver.style.display = 'none';
            rName.required = false;
            //rPhone.required = false;
        } else {
            receiver.style.display = 'block';
            rName.required = true;
            //rPhone.required = true;
        }
    });
}

if(courierBlock !== null) {
    if(selfPick.checked) {
        selfpickBlock.style.display = 'block';
        courierBlock.style.display = 'none';
    } else {
        courierBlock.style.display = 'block';
        selfpickBlock.style.display = 'none';
    }
}

if(selfPick !== null) {
    selfPick.addEventListener('click', function () {
        if (selfPick.checked) {
            selfpickBlock.style.display = 'block';
            courierBlock.style.display = 'none';
            document.getElementById('f1').setAttribute('data-ship_type', 'self');
            update_order();
            // update_cart();
        }
    });
}

if(courierPick !== null) {
    courierPick.addEventListener('click', function () {
        if (courierPick.checked) {
            selfpickBlock.style.display = 'none';
            courierBlock.style.display = 'block';
            document.getElementById('f1').setAttribute('data-ship_type', 'courier');
            update_order();
            // update_cart();
        }
    });
}

const makeOrder = document.querySelector('.make-order input[type=submit]');
if(makeOrder) {
    makeOrder.addEventListener('click', function (e) {
        //e.preventDefault();
    });
}


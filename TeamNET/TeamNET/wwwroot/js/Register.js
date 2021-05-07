var x = document.getElementsByClassName("item-event");

function ShowContent() {
    document.getElementById("event").classList.add('show');
}
function Validator(options) {
    var formElement = document.querySelector(options.form);
    if (formElement) {
        options.rules.forEach(function (rule) {
            var inputElement = formElement.querySelector(rule.selector);
            var errorElement = inputElement.parentElement.querySelector('.error');
            var question = inputElement.parentElement.querySelector('.question');
            if (question) {
                question.onclick = function () {
                    question.classList.add('show');
                }
            }
            if (inputElement) {
                inputElement.onclick = function () {
                    question.classList.add('show');
                }
                inputElement.onfocus = function () {
                    question.classList.add('show');
                }
            }
        });
    }
}
Validator.isEvent = function (selector) {
    return {
        selector: selector,
        test: function (value) {
            return value.trim() ? undefined : "フィールドに入力してください ."
        }
    };
}
Validator.isActions = function (selector) {
    return {
        selector: selector,
        test: function (value) {
            return value.trim() ? undefined : "フィールドに入力してください ."
        }
    };
}
Validator.isPower = function (selector) {
    return {
        selector: selector,
        test: function (value) {
            return value.trim() ? undefined : "フィールドに入力してください ."
        }
    };
}
Validator.isAbility = function (selector) {
    return {
        selector: selector,
        test: function (value) {
            return value.trim() ? undefined : "フィールドに入力してください ."
        }
    };
}
Validator.isThought = function (selector) {
    return {
        selector: selector,
        test: function (value) {
            return value.trim() ? undefined : "フィールドに入力してください ."
        }
    };
}
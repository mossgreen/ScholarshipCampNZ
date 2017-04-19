var ViewModel = function () {
    var self = this;
    self.books = ko.observableArray(); //observableArray class is the array version of observable
    self.error = ko.observable;

    var booksUri = '/api/books/';

    function ajaxHelper(uri, method, data) {
        self.error(''); //clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data:data?JSON.stringify(data):null
        })
            .fail(function (jqXHR, textStatus, errorThrown) {
                self.error(errorThrown);
            });
    };

    function getAllBooks() {
        ajaxHelper(booksUri, 'GET')
            .done(function (data) {
                self.books(data);
            });
    }

    //fetch the initial data
    getAllBooks();

};

ko.applyBindings(new ViewModel());
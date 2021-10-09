toastr.options = {
    "showDuration": "3000",
    "hideDuration": "1000"
}

$(document).ready(function () {


    //Editar Produto
    $('.editarProduto').click(function () {
        if (confirm('Deseja realmente excluir o produto?')) {
            var id = $(this).attr('id');

            $.ajax({
                type: "POST",
                url: "/Produtos/Excluir/",
                data: {
                    id: id
                },
                dataType: "json",
                success: function (response) {
                    toastr.error('Excluído com sucesso');
                },
                error: function(e) {
                    toastr.error('Erro');
                }
            }).done(function() {
                setTimeout(function() {
                        window.location.reload();
                    },
                    3500);
            });
        }
    });
})
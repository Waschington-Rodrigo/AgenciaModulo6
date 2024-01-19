import React from 'react';
import axios from 'axios';
import Link from 'next/link'; // Importe o Link para criar links de navegação
import { useEffect, useState } from "react";

export default function Index() {
    const [usuarios, setUsuarios] = useState([]);

    useEffect(() => {
        // Faça uma chamada GET para a API Spring Boot
        axios
            .get("https://localhost:7049/usuarios")
            .then((response) => {
                setUsuarios(response.data);
            })
            .catch((error) => {
                console.error("Erro ao buscar a lista de Usuarios:", error);
            });
    }, []);

    return (
        <div className="container-fluid opacity">
            
            <table className="table table-responsive table-hover">
                <thead className="table-dark">
                    <tr className="text-center">
                        <th scope="col">Id</th>
                        <th scope="col">Nome</th>
                        <th scope="col">email</th>
                        <th scope="col">Cidade</th>
                        <th scope="col">Estado</th>
                    </tr>
                </thead>
                <tbody>
                    {usuarios.map((usuario) => (

                        <tr className="text-center">
                            <th scope="row">
                                {usuario.id}
                            </th>
                            <td>
                                 {usuario.nome}
                            </td>
                            <td>
                                {usuario.email}
                            </td>
                            <td>
                                {usuario.cidade}
                            </td>
                            <td>
                                {usuario.estado}
                            </td>
                        
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    )
}

import React, { useState } from 'react';

const Student = () => {
    const [fullName, setFullName] = useState("");
    const handleForm = () => {
        if (fullName == "") alert("Name field is required")
        else {
            alert("Hello " + fullName);
        }
    }
    return (
        <>
            <form onSubmit={(e) => {
                e.preventDefault();
                handleForm();
            }}>
                <input type="text" placeholder="Enter FullName" value={fullName} onChange={(e) => {
                    setFullName(e.target.value);
                }} />
                <input type="submit"/>
            </form>
        </>
    )
}

export { Student };
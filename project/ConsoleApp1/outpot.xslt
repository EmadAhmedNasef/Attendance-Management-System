<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html" indent="yes"/>
  
  <xsl:template match="/">
    <html>
      <head>
        <title>Attendance Report</title>
      </head>
      <body>
        <h1>Attendance Report</h1>
        <table border="1">
          <tr>
            <th>Date</th>
            <th>Class Name</th>
            <th>Student Name</th>
            <th>Student ID</th>
            <th>Status</th>
          </tr>
          <xsl:apply-templates select="//record"/>
        </table>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="record">
    <tr>
      <td><xsl:value-of select="date"/></td>
      <td><xsl:value-of select="class/@name"/></td>
      <td><xsl:value-of select="class/Students/Student/studentname"/></td>
      <td><xsl:value-of select="class/Students/Student/studentID"/></td>
      <td><xsl:value-of select="class/Students/Student/status"/></td>
    </tr>
  </xsl:template>
</xsl:stylesheet>
